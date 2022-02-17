using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class Fireball : Entity
    {
        public override string Name => "Fireball";

        public override VarInt Type => 43;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.0, 1.0, 1.0);

        public override Identifier Identifier => new("fireball");

        public Slot Item { get; set; }
    }
}
