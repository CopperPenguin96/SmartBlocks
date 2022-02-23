using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class Snowball : Entity
    {
        public override string Name => "Snowball";

        public override VarInt Type => 83;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

        public override Identifier Identifier => new("snowball");

        public Slot Item { get; set; }
    }
}
