using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Ageable;

public class Hoglin : Animal
{
    public override string Name => "Hoglin";

    public override VarInt Type => 36;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(1.39648, 1.4, 1.39648);

    public override Identifier Identifier => new("hoglin");

    public bool IsZombieImmune { get; set; } = false;
    
}