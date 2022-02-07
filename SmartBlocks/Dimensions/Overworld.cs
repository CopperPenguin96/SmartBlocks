using MinecraftTypes;

namespace SmartBlocks.Dimensions
{
    public class Overworld : Dimension
    {
        public override Identifier Type => "overworld";

        public override Identifier GenType => "noise";

        public override Identifier Settings => "overworld";

        public bool LargeBiomes { get; set; } = false;

        public override Identifier BiomeSourceType => "vanilla_layered";
    }
}
