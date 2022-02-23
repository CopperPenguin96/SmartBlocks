using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Guardian : Monster
    {
        public override string Name => "Guardian";

        public override VarInt Type => 35;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.85, 0.85, 0.85);

        public override Identifier Identifier => new("guardian");

        public bool IsRetractingSpikes { get; set; } = false;

        public VarInt Target { get; set; }
    }
}
