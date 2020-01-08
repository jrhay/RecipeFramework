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

        public override string ToString()
        {
            StringBuilder StepString = new StringBuilder(3);
            StepString.Append(Instruction);
            if (!String.IsNullOrEmpty(HACCP))
                StepString.Append(" [HACCP: " + HACCP + "]");

            foreach (string note in Notes)
                StepString.Append(" (" + note + ")");

            return StepString.ToString();
        }
    }
}
