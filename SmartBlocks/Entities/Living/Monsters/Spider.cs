using MinecraftTypes;
using SmartBlocks.Entities.Flags;
using SmartBlocks.Entities.Living.Mobs;
using SmartBlocks.Utils;

namespace SmartBlocks.Entities.Living.Monsters;

public class Spider : Monster
{
    public override string Name => "Spider";

    public override VarInt Type => 85;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(1.4, 0.9, 1.4);

    public override Identifier Identifier => new("spider");

    private byte _spider = 0;

    public bool IsClimbing
    {
        get => FlagsHelper.IsSet(_spider, (byte) SpiderFlag.Climbing);
        set
        {
            if (value) FlagsHelper.Set(ref _spider, (byte) SpiderFlag.Climbing);
            else FlagsHelper.Unset(ref _spider, (byte) SpiderFlag.Climbing);
        }
    }
    
}