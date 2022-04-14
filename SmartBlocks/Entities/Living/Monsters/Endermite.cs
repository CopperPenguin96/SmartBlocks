using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Monsters;

public class Endermite : Monster
{
    public override string Name => "Endermite";

    public override VarInt Type => 22;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.4, 0.3, 0.4);

    public override Identifier Identifier => "endermite";
    
}