using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Monsters;

public class Giant : Monster
{
    public override string Name => "Giant";

    public override VarInt Type => 31;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(3.6, 12.0, 3.6);

    public override Identifier Identifier => new("giant");
    
}