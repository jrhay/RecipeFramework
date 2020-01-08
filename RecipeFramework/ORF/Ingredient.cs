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

        public List<Amount> Amounts { get; set; }

        public List<Ingredient> Substitutions { get; set; }

        public Ingredient(string name)
        {
            this.Name = name;
        }
    }
}
