using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
