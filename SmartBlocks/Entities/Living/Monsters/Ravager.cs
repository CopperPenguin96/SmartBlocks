using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Monsters;

public class Ravager : Raider
{
    public override string Name => "Ravager";

    public override VarInt Type => 72;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(1.95, 2.2, 1.95);

    public override Identifier Identifier => new("ravager");
    
}