using System;

namespace GemBlocks.Levels
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
