using RecipeFramework.Tools;
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
        private static readonly Type _yieldType = typeof(Yield);
        private static readonly Type _ingredientType = typeof(Ingredient);
        private static readonly Type _nutritionType = typeof(Nutrition);

        public bool Accepts(Type type)
        {
            return
                (type == _yieldType) ||
                (type == _ingredientType) ||
                (type == _nutritionType);
        }

        public object ReadYaml(IParser parser, Type type)
        {
            if (type == _yieldType)
            {
                return Yield.Parse(parser);
            }
            else if (type == _ingredientType)
            {
                return Ingredient.Parse(parser);
            }
            else if (type == _nutritionType)
            {
                parser.Consume<MappingStart>();

                Nutrition nutrition = new Nutrition();
                parser.MoveNext();

                int nestlevel = 1;
                do
                {
                    // TODO: Finish parsing nutrition info
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
