using MinecraftTypes;
using SmartBlocks.Entities.Flags;
using SmartBlocks.Utils;

namespace SmartBlocks.Entities.Living.Mobs;

public class Bat : AmbientCreature
{
    public override string Name => "Bat";

    public override VarInt Type => 4;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.5, 0.9, 0.5);

    public override Identifier Identifier => "bat";

    private byte _hanging = 0;
    public bool IsHanging
    {
        get => FlagsHelper.IsSet(_hanging, (byte) BatFlag.IsHanging);
        set
        {
            if (value) FlagsHelper.Set(ref _hanging, (byte) BatFlag.IsHanging);
            else FlagsHelper.Unset(ref _hanging, (byte) BatFlag.IsHanging);
        }
    }
    
}