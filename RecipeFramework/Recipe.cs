using System;
using System.Collections.Generic;
using System.IO;
using RecipeFramework.ORF;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace RecipeFramework
{
    public class Recipe
    {
        public static Recipe LoadFromFile(string Pathname)
        {
            using (FileStream recipeFile = new FileStream(Pathname, FileMode.Open))
                return LoadFromStream(recipeFile);
        }

        public static Recipe LoadFromStream(Stream recipeStream)
        {
            IDeserializer deserializer = new DeserializerBuilder()
                .WithTypeConverter(new ORFTypeConverter())
                .IgnoreFields()
                .Build();

            using (StreamReader recipeReader = new StreamReader(recipeStream))
            {
                Recipe recipe = deserializer.Deserialize<Recipe>(recipeReader);
                return recipe;
            }
        }

        #region Open Recipe Format properties

        [YamlMember(Alias = "recipe_uuid", Order = 2)]
        public string UUID { get; set; }
        
        [YamlMember(Alias = "recipe_name", Order = 1)]
        public string Name { get; set; }

        [YamlMember(Alias = "author", Order = 3)]
        public string Author { get; set; }

        [YamlMember(Alias = "source_url", Order = 4)]
        public string SourceUrl { get; set; }
        
        [YamlMember(Alias = "source_book", Order = 5)]
        public string Source { get; set; }

        [YamlMember(Alias = "oven_temp", Order = 6)]
        public string OvenTemp { get; set; }

        /// <summary>
        /// Convection oven fan setting. Possible values are
        /// "Off", "Low", and "High".
        /// </summary>
        [YamlMember(Alias = "oven_fan", Order = 7)]
        public string OvenFan { get; set; }

        [YamlMember(Alias = "oven_time", Order = 8)]
        public string OvenTime { get; set; }

        [YamlMember(Alias = "bake_time", Order = 9)]
        public string BakeTime { get { return OvenTime; } set { OvenTime = value; } }

        [YamlMember(Alias = "yields", Order = 10)]
        public List<Yield> Yields { get; set; }

        [YamlMember(Alias = "ingredients", Order = 11)]
        public List<Ingredient> Ingredients { get; set; }

        [YamlMember(Alias = "steps", Order = 12)]
        public List<Step> Steps { get; set; }

        [YamlMember(Alias = "notes", Order = 13)]
        public List<String> Notes { get; set; } = new List<string>();

        [YamlMember(Alias = "nutrition", Order = 14)]
        public Nutrition Nutrition { get; set; }
        #endregion
    }
}
