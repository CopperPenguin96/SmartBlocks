using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Monsters;

public class EnderDragon : Mob
{
    public override string Name => "Ender Dragon";

    public override VarInt Type => 20;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new (16.0, 8.0, 16.0);

    public override Identifier Identifier => "ender_dragon";

    public DragonPhase Phase { get; set; } = DragonPhase.HoveringNoAi;
    
}