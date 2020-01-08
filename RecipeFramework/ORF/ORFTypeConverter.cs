using System;
using System.Collections.Generic;
using System.Text;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace RecipeFramework.ORF
{
    class ORFTypeConverter : IYamlTypeConverter
    {
        private static readonly Type _yieldNodeType = typeof(Yield);
        private static readonly Type _ingredientType = typeof(Ingredient);
        private static readonly Type _nutritionType = typeof(Nutrition);

        public bool Accepts(Type type)
        {
            return
                (type == _yieldNodeType) ||
                (type == _ingredientType) ||
                (type == _nutritionType);
        }

        public object ReadYaml(IParser parser, Type type)
        {
            if (type == _yieldNodeType)
            {
                parser.Consume<MappingStart>();

                string unit = parser.Consume<Scalar>().Value;
                string amount = parser.Consume<Scalar>().Value;

                parser.Consume<MappingEnd>();
                return new Yield(int.Parse(amount), unit);
            }
            else if (type == _ingredientType)
            {
                parser.Consume<MappingStart>();

                string name = parser.Consume<Scalar>().Value;
                Ingredient ingredient = new Ingredient(name);

                int nestlevel = 1;
                do
                {
                    // TODO: Finish parsing ingredients
                    nestlevel += parser.Current.NestingIncrease;
                    parser.MoveNext();
                } while (nestlevel > 1);

                parser.Consume<MappingEnd>();
                return ingredient;
            }
            else if (type == _nutritionType)
            {
                parser.Consume<MappingStart>();

                Nutrition nutrition = new Nutrition();
                parser.MoveNext();

                int nestlevel = 1;
                do
                {
                    // TODO: Finish parsing ingredients
                    nestlevel += parser.Current.NestingIncrease;
                    parser.MoveNext();
                } while (nestlevel > 1);

                parser.Consume<MappingEnd>();
                return nutrition;
            }

            throw new Exception("Unknown Element:" + parser.Current.ToString());
        }

        public void WriteYaml(IEmitter emitter, object value, Type type)
        {
            throw new NotImplementedException();
        }
    }
}
