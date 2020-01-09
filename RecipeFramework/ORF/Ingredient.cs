using System;
using System.Collections.Generic;
using System.Text;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace RecipeFramework.ORF
{
    public class Ingredient
    {
        public string Name { get; set; }

        [YamlMember(Alias="usda_num")]
        public string USDA { get; set; }

        public List<Amount> Amounts { get; set; } = new List<Amount>();

        public List<Ingredient> Substitutions { get; set; } = new List<Ingredient>();

        public List<string> Processing { get; set; } = new List<String>();

        public List<string> Notes { get; set; } = new List<String>();

        public Ingredient(string name)
        {
            this.Name = name;
        }

        public string ToString(int SelectedYield)
        {
            StringBuilder ingredientString = new StringBuilder(3);

            if (Amounts.Count > SelectedYield)
                ingredientString.Append(Amounts[SelectedYield]);
            else if (Amounts.Count > 0)
                ingredientString.Append(Amounts[0]);

            ingredientString.Append(" ");
            ingredientString.Append(Name);

            if (Processing.Count > 0)
            {
                ingredientString.Append(" [");
                for (int i = 0; i < Processing.Count - 1; i++)
                    ingredientString.Append(Processing[i] + ", ");
                ingredientString.Append(Processing[Processing.Count - 1]);
                ingredientString.Append("]");

            }

            if (Substitutions.Count > 0)
                ingredientString.Append("*");

            return ingredientString.ToString();
        }

        internal static Ingredient Parse(IParser parser)
        {
            parser.Consume<MappingStart>();

            string name = parser.Consume<Scalar>().Value;
            Ingredient ingredient = new Ingredient(name);

            bool HasMappingStart = parser.TryConsume<MappingStart>(out _);

            do
            {
                Scalar next = parser.Consume<Scalar>();
                if (next.Value == "usda_num")
                    ingredient.USDA = parser.Consume<Scalar>().Value;
                else if (next.Value == "amounts")
                {
                    parser.Consume<SequenceStart>();
                    do
                    {
                        ingredient.Amounts.Add(Amount.Parse(parser));
                    }
                    while (parser.TryConsume<SequenceEnd>(out _) == false);
                }
                else if (next.Value == "substitutions")
                {
                    parser.Consume<SequenceStart>();
                    do
                    {
                        ingredient.Substitutions.Add(Ingredient.Parse(parser));
                    }
                    while (parser.TryConsume<SequenceEnd>(out _) == false);
                }
                else if (next.Value == "notes")
                {
                    parser.Consume<SequenceStart>();
                    do
                    {
                        ingredient.Notes.Add(parser.Consume<Scalar>().Value);
                    }
                    while (parser.TryConsume<SequenceEnd>(out _) == false);
                }
                else if (next.Value == "processing")
                {
                    parser.Consume<SequenceStart>();
                    do
                    {
                        ingredient.Processing.Add(parser.Consume<Scalar>().Value);
                    }
                    while (parser.TryConsume<SequenceEnd>(out _) == false);
                }
            } while (parser.TryConsume<MappingEnd>(out _) == false);

            if (HasMappingStart)
                parser.Consume<MappingEnd>();

            return ingredient;
        }

    }
}
