using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class ExperienceOrb : Entity
    {
        public override string Name => "Experience Orb";

        public override VarInt Type => 25;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => true;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.5, 0.5, 0.5);

        public override Identifier Identifier => "experience_orb";

        public short AwardAmount { get; set; }
    }
}
