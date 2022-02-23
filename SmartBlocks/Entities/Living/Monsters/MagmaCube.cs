using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class MagmaCube : Monster
    {
        public override string Name => "Magma Cube";

        public override VarInt Type => 48;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        private const double Multiplier = 0.51000005;

        public override BoundingBox BoundingBox => new(
            Multiplier * Size, Multiplier * Size, Multiplier * Size
            );

        public override Identifier Identifier => new("magma_cube");

        public double Size { get; set; }
    }
}
