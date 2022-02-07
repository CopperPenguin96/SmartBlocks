using MinecraftTypes;

namespace SmartBlocks.Dimensions
{
    public abstract class Dimension
    {
        public virtual Identifier Type { get; set; }

        public virtual Identifier GenType { get; set; }

        public virtual Identifier Settings { get; set; }

        public virtual Identifier BiomeSourceType { get; set; }
    }
}
