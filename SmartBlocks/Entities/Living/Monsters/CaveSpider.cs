using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Monsters;

public class CaveSpider : Spider
{
    public override string Name => "Cave Spider";

    public override VarInt Type => 9;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.7, 0.5, 0.7);

    public override Identifier Identifier => "cave_spider";
    
}