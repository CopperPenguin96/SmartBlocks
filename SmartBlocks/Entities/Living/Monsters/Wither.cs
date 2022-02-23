using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Wither : Monster
    {
        public override string Name => "Wither";

        public override VarInt Type => 102;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.9, 3.5, 0.9);

        public override Identifier Identifier => new("wither");

        public VarInt CenterHeadTarget { get; set; } = 0;

        public VarInt LeftHeadTarget { get; set; } = 0;

        public VarInt RightHeadTarget { get; set; } = 0;

        public VarInt InvulnerableTime { get; set; } = 0;
    }
}
