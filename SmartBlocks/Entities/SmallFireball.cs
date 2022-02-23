using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class SmallFireball : Entity
    {
        public override string Name => "Small Fireball";

        public override VarInt Type => 81;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.3125, 0.3125, 0.3125);

        public override Identifier Identifier => new("small_fireball");

        public Slot Item { get; set; }
    }
}
