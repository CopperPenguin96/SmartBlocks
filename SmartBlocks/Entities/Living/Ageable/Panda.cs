using MinecraftTypes;
using SmartBlocks.Entities.Flags;
using SmartBlocks.Entities.Living.Mobs;
using SmartBlocks.Utils;

namespace SmartBlocks.Entities.Living.Ageable;

public class Panda : Animal
{
    public override string Name => "Panda";

    public override VarInt Type => 61;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(1.3, 1.25, 1.3);

    public override Identifier Identifier => new("panda");

    /// <summary>
    /// More information is needed here.
    /// Set to 32 when something happens, and then down at 0 again.
    /// </summary>
    public int BreedTimer { get; set; } = 0;

    /// <summary>
    /// Counts up from 0, when it hits 1 the entity.panda.pre_sneeze
    /// event plays and when it hits 21 the sneeze event plays, then resets to 0
    /// </summary>
    public int SneezeTimer { get; set; } = 0;

    /// <summary>
    /// If nonzero, counts upwards
    /// </summary>
    public int EatTimer { get; set; } = 0;

    public byte MainGene { get; set; } = 0;

    public byte HiddenGene { get; set; } = 0;

    private byte _panda = 0;

    public bool IsSneezing
    {
        get => FlagsHelper.IsSet(_panda, (byte)PandaFlag.Sneezing);
        set
        {
            if (value) FlagsHelper.Set(ref _panda, (byte)PandaFlag.Sneezing);
            else FlagsHelper.Unset(ref _panda, (byte)PandaFlag.Sneezing);
        }
    }

    public bool IsRollng
    {
        get => FlagsHelper.IsSet(_panda, (byte)PandaFlag.Rolling);
        set
        {
            if (value) FlagsHelper.Set(ref _panda, (byte) PandaFlag.Rolling);
            else FlagsHelper.Unset(ref _panda, (byte) PandaFlag.Rolling);
        }
    }

    public bool IsSitting
    {
        get => FlagsHelper.IsSet(_panda, (byte)PandaFlag.Sitting);
        set
        {
            if (value) FlagsHelper.Set(ref _panda, (byte)PandaFlag.Sitting);
            else FlagsHelper.Unset(ref _panda, (byte)PandaFlag.Sitting);
        }
    }

    public bool IsOnBack
    {
        get => FlagsHelper.IsSet(_panda, (byte)PandaFlag.OnBack);
        set
        {
            if (value) FlagsHelper.Set(ref _panda, (byte)PandaFlag.OnBack);
            else FlagsHelper.Unset(ref _panda, (byte)PandaFlag.OnBack);
        }
    }
    
}