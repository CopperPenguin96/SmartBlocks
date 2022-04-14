using SmartBlocks.Utils;

namespace SmartBlocks.Entities.Arrows;

public class AbstractArrow : Entity
{
    #region Flags

    private byte _arrowMask = 0;

    public bool IsCritical
    {
        get => FlagsHelper.IsSet(_arrowMask, (byte) ArrowFlag.Critical);
        set
        {
            if (value) FlagsHelper.Set(ref _arrowMask, (byte) ArrowFlag.Critical);
            else FlagsHelper.Unset(ref _arrowMask, (byte) ArrowFlag.Critical);
        }
    }

    public bool IsNoClip
    {
        get => FlagsHelper.IsSet(_arrowMask, (byte) ArrowFlag.NoClip);
        set
        {
            if (value) FlagsHelper.Set(ref _arrowMask, (byte) ArrowFlag.NoClip);
            else FlagsHelper.Unset(ref _arrowMask, (byte) ArrowFlag.NoClip);
        }
    }

    #endregion

    public byte PiercingLevel { get; set; } = 0;
    public override void Spawn()
    {
        throw new NotImplementedException();
    }
}