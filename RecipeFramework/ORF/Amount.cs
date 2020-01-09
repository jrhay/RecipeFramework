using RecipeFramework.Tools;
using System;
using System.Collections.Generic;
using System.Text;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;

namespace RecipeFramework.ORF
{
    public class Amount
    {
        decimal amount { get; set; } = 0;
        string unit { get; set; } = null;

        public Amount(decimal Amount, string Units)
        {
            amount = Amount;
            unit = Units;
        }

        public Amount()
        { }

        public override string ToString()
        {
            return amount.ToString() + " " + unit;
        }

        internal static Amount Parse(IParser parser)
        {
            parser.Consume<MappingStart>();
            string amount = null;
            string unit = null;
            do
            {
                Scalar token = parser.Consume<Scalar>();
                if (token.Value == "amount")
                    amount = parser.Consume<Scalar>().Value;
                else if (token.Value == "unit")
                    unit = parser.Consume<Scalar>().Value;
            } while (string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(unit));
            parser.Consume<MappingEnd>();

            return new Amount(Fraction.NumericValue(amount), unit);
        }

    }
}
