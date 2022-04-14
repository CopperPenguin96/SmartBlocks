using MinecraftTypes;
using SmartBlocks.Worlds;

namespace SmartBlocks.Entities;

public class FallingBlock : Entity
{
    public Position SpawnPosition { get; set; } = new(0, 0, 0);

    public override string Name => "Falling Block";

    public override VarInt Type => 27;

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.98, 0.98, 0.98);

    public override Identifier Identifier => new("falling_block");

    public World World { get; set; }
}