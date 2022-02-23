using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Zombie : Monster
    {
        public override string Name => "Zombie";

        public override VarInt Type => 107;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 1.95, 0.6);

        public override Identifier Identifier => new("zombie");

        public bool IsBaby { get; set; } = false;

        public VarInt Unused { get; set; } = 0; // Previously type

        public bool IsBecomingDrowned { get; set; } = false;
    }
}
