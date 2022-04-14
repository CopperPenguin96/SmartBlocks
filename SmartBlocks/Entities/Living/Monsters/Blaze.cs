using MinecraftTypes;
using SmartBlocks.Entities.Flags;
using SmartBlocks.Entities.Living.Mobs;
using SmartBlocks.Utils;

namespace SmartBlocks.Entities.Living.Monsters;

public class Blaze : Monster
{
    public override string Name => "Blaze";

    public override VarInt Type => 6;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.6, 1.8, 0.6);

    public override Identifier Identifier => "blaze";

    private byte _blaze;

    public bool IsOnFire
    {
        get => FlagsHelper.IsSet(_blaze, (byte) BlazeFlag.OnFire);
        set
        {
            if (value) FlagsHelper.Set(ref _blaze, (byte) BlazeFlag.OnFire);
            else FlagsHelper.Unset(ref _blaze, (byte) BlazeFlag.OnFire);
        }
    }
    
}