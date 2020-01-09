using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeFramework.Tools
{
    class Fraction
    {
        public Decimal Value { get; set; }

        public Fraction(String input)
        {
            Value = this.Parse(input);
        }

        private Decimal Parse(String input)
        {
            input = (input ?? String.Empty).Trim();
            if (String.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("input");
            }

            // standard decimal number (e.g. 1.125)
            if (input.IndexOf('.') != -1 || (input.IndexOf(' ') == -1 && input.IndexOf('/') == -1 && input.IndexOf('\\') == -1))
            {
                Decimal result;
                if (Decimal.TryParse(input, out result))
                    return result;
            }

            String[] parts = input.Split(new[] { ' ', '/', '\\' }, StringSplitOptions.RemoveEmptyEntries);

            // stand-off fractional (e.g. 7/8)
            if (input.IndexOf(' ') == -1 && parts.Length == 2)
            {
                Decimal num, den;
                if (Decimal.TryParse(parts[0], out num) && Decimal.TryParse(parts[1], out den))
                    return num / den;
            }

            // Number and fraction (e.g. 2 1/2)
            if (parts.Length == 3)
            {
                Decimal whole, num, den;
                if (Decimal.TryParse(parts[0], out whole) && Decimal.TryParse(parts[1], out num) && Decimal.TryParse(parts[2], out den))
                {
                    return whole + (num / den);
                }
            }

            // Bogus / unable to parse
            return Decimal.Zero;
        }

        public static implicit operator Double(Fraction number)
        {
            return (Double)number.Value;
        }

        public static implicit operator Decimal(Fraction number)
        {
            return number.Value;
        }

        public static Decimal NumericValue(String number)
        {
            return new Fraction(number).Value;
        }
    }
}
