using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class SmallFireball : Entity
    {
        public override string Name => "Small Fireball";

        public override VarInt Type => 81;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.3125, 0.3125, 0.3125);

        public override Identifier Identifier => new("small_fireball");

        public Slot Item { get; set; }
    }
}
