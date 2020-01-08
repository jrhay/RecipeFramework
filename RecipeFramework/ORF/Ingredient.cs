using System;
using System.Collections.Generic;
using System.Text;
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

            return ingredientString.ToString();
        }
    }
}
