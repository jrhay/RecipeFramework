using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeFramework.ORF
{
    public class Yield : Amount
    {
        public Yield(int Amount, string Units) : base(Amount, Units) { }

        public Yield() : base() { }

    }
}
