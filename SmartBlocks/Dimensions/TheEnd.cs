using MinecraftTypes;

namespace SmartBlocks.Dimensions
{
    public class TheEnd : Dimension
    {
        public override Identifier Type => "the_end";

        public override Identifier GenType => "noise";

        public override Identifier Settings => "end";

        public override Identifier BiomeSourceType => "the_end";
    }
}
