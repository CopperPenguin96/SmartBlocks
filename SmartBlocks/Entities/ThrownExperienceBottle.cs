using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class ThrownExperienceBottle : Entity
    {
        public override string Name => "Thrown Experience Bottle";

        public override VarInt Type => 91;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

        public override Identifier Identifier => new("experience_bottle");

        public Slot Item { get; set; }
    }
}
