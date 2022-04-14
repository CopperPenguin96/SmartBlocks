using MinecraftTypes;
using SmartBlocks.Entities.Attributes;
using SmartBlocks.Entities.Flags;
using SmartBlocks.Entities.Living.Mobs;
using SmartBlocks.Utils;

namespace SmartBlocks.Entities.Living.Ageable;

public class Bee : Animal
{
    public override string Name => "Bee";

    public override VarInt Type => 5;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.7, 0.6, 0.7);

    public override Identifier Identifier => "bee";

    private byte _beeFlags = 0;

    public bool IsAngry
    {
        get => FlagsHelper.IsSet(_beeFlags, (byte) BeeFlag.Angry);
        set
        {
            if (value) FlagsHelper.Set(ref _beeFlags, (byte) BeeFlag.Angry);
            else FlagsHelper.Unset(ref _beeFlags, (byte) BeeFlag.Angry);
        }
    }

    public bool HasStung
    {
        get => FlagsHelper.IsSet(_beeFlags, (byte) BeeFlag.Stung);
        set
        {
            if (value) FlagsHelper.Set(ref _beeFlags, (byte) BeeFlag.Stung);
            else FlagsHelper.Unset(ref _beeFlags, (byte) BeeFlag.Stung);
        }
    }

    public bool HasNectar
    {
        get => FlagsHelper.IsSet(_beeFlags, (byte) BeeFlag.Nectar);
        set
        {
            if (value) FlagsHelper.Set(ref _beeFlags, (byte) BeeFlag.Nectar);
            else FlagsHelper.Unset(ref _beeFlags, (byte) BeeFlag.Nectar);
        }
    }

    public VarInt AngerTimeTicks { get; set; } = 0;

    public double FlyingSpeed
    {
        get => Attributes["generic.flying_speed"].Value;
        set
        {
            Attributes["generic.flying_speed"].Value = value;
        }
    }

    public override void Spawn()
    {
        base.Spawn();
        Attributes.Add(MobAttribute.FlyingSpeed);
    }

}