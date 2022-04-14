using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Monsters;

public class Silverfish : Monster
{
    public override string Name => "Silverfish";

    public override VarInt Type => 77;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.4, 0.3, 0.4);

    public override Identifier Identifier => new("silverfish");
    
}