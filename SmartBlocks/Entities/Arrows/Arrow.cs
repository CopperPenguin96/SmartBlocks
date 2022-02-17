using MinecraftTypes;

namespace SmartBlocks.Entities.Arrows
{
    public class Arrow : AbstractArrow
    {
        public override string Name => "Arrow";

        public override VarInt Type => 2;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.5, 0.5, 0.5);

        public override Identifier Identifier => "arrow";

        /// <summary>
        /// Color, -1 for no particles
        /// </summary>
        public VarInt Color { get; set; } = -1;
    }
}
