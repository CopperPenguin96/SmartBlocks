using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class Snowball : Entity
    {
        public override string Name => "Snowball";

        public override VarInt Type => 83;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

        public override Identifier Identifier => new("snowball");

        public Slot Item { get; set; }
    }
}
