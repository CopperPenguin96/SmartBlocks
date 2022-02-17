using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class ThrownPotion : Entity
    {
        public override string Name => "Thrown Potion";

        public override VarInt Type => 92;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

        public override Identifier Identifier => new("potion");

        public Slot Item { get; set; }
    }
}
