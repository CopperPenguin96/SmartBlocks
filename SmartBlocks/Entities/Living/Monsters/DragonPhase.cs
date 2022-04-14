namespace SmartBlocks.Entities.Living.Monsters;

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