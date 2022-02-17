using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class ItemFrame : Entity
    {
        public override string Name => "Item Frame";

        public override VarInt Type => 42;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.75, 0.75, 0.75);

        public override Identifier Identifier => new("item_frame");

        public Slot Item { get; set; }

        public VarInt Rotation { get; set; } = 0;
    }
}
