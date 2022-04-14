using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Ageable;

public class Rabbit : Animal
{
    public override string Name => "Rabbit";

    public override VarInt Type => 71;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.4, 0.5, 0.4);

    public override Identifier Identifier => new("rabbit");

    public VarInt RabbitType { get; set; } = 0;
    
}