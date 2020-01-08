using System;
using System.Collections.Generic;
using System.Text;
using YamlDotNet.Serialization;

namespace RecipeFramework.ORF
{
    public class Step
    {
        [YamlMember(Alias = "step")]
        public string Instruction { get; set; } = null;

        [YamlMember(Alias = "haccp")]
        public string HACCP { get; set; } = null;

        [YamlMember(Alias = "notes")]
        public List<string> Notes { get; set; } = new List<string>();

        public Step()
        { }
    }
}
