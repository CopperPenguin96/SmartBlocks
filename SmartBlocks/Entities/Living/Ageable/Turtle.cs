using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Ageable;

public class Turtle : Animal
{
    public override string Name => "Turtle";

    public override VarInt Type => 96;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(1.2, 0.4, 1.2);

    public override Identifier Identifier => new("turtle");

    public Position HomePos { get; set; } = new(0, 0, 0);

    public bool HasEgg { get; set; } = false;

    public bool IsLayingEgg { get; set; } = false;

    public Position TravelPos { get; set; } = new(0, 0, 0);

    public bool IsGoingHome { get; set; } = false;

    public bool IsTraveling { get; set; } = false;
    
}