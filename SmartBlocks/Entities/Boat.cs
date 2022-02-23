using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class Boat : Entity
    {
        public override string Name => "Boat";

        public override VarInt Type => 7;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.375, 0.5625, 1.375);

        public override Identifier Identifier => "boat";

        public VarInt TimeSinceLastHit { get; set; } = 0;

        public VarInt ForwardDirection { get; set; } = 1;

        public float DamageTaken { get; set; } = 0.0f;

        //public WoodType WoodType { get; set; } = WoodType.Oak;

        public bool IsLeftPaddleTurning { get; set; } = false;

        public bool IsRightPaddleTurning { get; set; } = false;

        public VarInt SplashTimer { get; set; } = 0;
    }
}
