using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Monsters;

public class Witch : Raider
{
    public override string Name => "Witch";

    public override VarInt Type => 101;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.6, 1.95, 0.6);

    public override Identifier Identifier => new("witch");

    public bool IsDrinkingPotion { get; set; } = false;
    
}