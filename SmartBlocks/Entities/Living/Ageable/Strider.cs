using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Ageable;

public class Strider : Animal
{
    public override string Name => "Strider";

    public override VarInt Type => 88;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.9, 1.7, 0.9);

    public override Identifier Identifier => new("strider");

    /// <summary>
    /// Total time to "boost" with warped fungus on a stick for
    /// </summary>
    public VarInt BoostTime { get; set; } = 0;

    /// <summary>
    /// True, unless riding a vehicle or on or n a
    /// block tagged with strider_warm_blocks
    /// </summary>
    public bool IsShaking { get; set; } = false;

    public bool HasSaddle { get; set; } = false;
    
}