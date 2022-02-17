using MinecraftTypes;

namespace SmartBlocks.Entities.Arrows
{
    public class SpectralArrow : AbstractArrow
    {
        public override string Name => "Spectral Arrow";

        public override VarInt Type => 84;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.5, 0.5, 0.5);

        public override Identifier Identifier => new("spectral_arrow");
    }
}
