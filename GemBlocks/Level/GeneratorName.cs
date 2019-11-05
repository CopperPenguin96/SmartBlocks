using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemBlocks.Level
{
    public enum GeneratorName
    {
        [Name("default")]
        Default,
        [Name("amplified")]
        Amplified,
        [Name("largeBiomes")]
        LargeBiomes
    }

    public class NameAttribute : Attribute
    {
        public string Name;

        public NameAttribute(string t)
        {
            Name = t;
        }
    }

}
