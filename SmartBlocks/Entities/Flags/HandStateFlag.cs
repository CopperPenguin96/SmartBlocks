namespace SmartBlocks.Entities.Flags;

public enum HandStateFlag : byte
{
    /// <summary>
    /// Is hand active
    /// </summary>
    HandActive = 0x01,

    /// <summary>
    /// Active hand 0 = main hand, 1 = offhand
    /// </summary>
    ActiveHand = 0x02,

    /// <summary>
    /// is in spin attack
    /// </summary>
    RiptdeSpinAttack = 0x04
}