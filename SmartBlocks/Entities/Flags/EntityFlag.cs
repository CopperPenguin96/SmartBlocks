namespace SmartBlocks.Entities.Flags
{
    public enum EntityFlag : byte
    {
        OnFire = 0x01,
        Crouching = 0x02,
        Unused = 0x04,
        Sprinting = 0x08,
        Swimming = 0x10,
        Invisible = 0x20,
        Glowing = 0x40,
        FlyingElytra = 0x80
    }
}
