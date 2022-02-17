using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class EnderDragon : Mob
    {
        public override string Name => "Ender Dragon";

        public override VarInt Type => 20;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new (16.0, 8.0, 16.0);

        public override Identifier Identifier => "ender_dragon";

        public DragonPhase Phase { get; set; } = DragonPhase.HoveringNoAi;
    }

    public enum DragonPhase
    {
        Circling = 0,
        Strafing = 1,
        FlyingToPortalToLand = 2,
        LandingOnPortal = 3,
        TakingOffFromPortal = 4,
        LandedBreathAttack = 5,
        LandedLookingForPlayer = 6,
        LandedRoarBeforeBreathAttack = 7,
        ChargingPlayer = 8,
        FlyingToDie = 9,
        HoveringNoAi = 10
    }
}
