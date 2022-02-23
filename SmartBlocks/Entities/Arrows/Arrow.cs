using MinecraftTypes;

namespace SmartBlocks.Entities.Arrows
{
    public class Arrow : AbstractArrow
    {
        public override string Name => "Arrow";

        public override VarInt Type => 2;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.5, 0.5, 0.5);

        public override Identifier Identifier => "arrow";

        /// <summary>
        /// Color, -1 for no particles
        /// </summary>
        public VarInt Color { get; set; } = -1;
    }
}
