using System;
using System.Collections.Generic;
using System.Text;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;

namespace RecipeFramework.ORF
{
    public class Yield : Amount
    {
        public Yield(int Amount, string Units) : base(Amount, Units) { }

        public Yield() : base() { }

        internal static Yield Parse(IParser parser)
        {
            parser.Consume<MappingStart>();

            string unit = parser.Consume<Scalar>().Value;
            string amount = parser.Consume<Scalar>().Value;

            parser.Consume<MappingEnd>();
            return new Yield(int.Parse(amount), unit);
        }

    }
}
