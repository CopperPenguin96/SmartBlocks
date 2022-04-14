using MinecraftTypes;

namespace SmartBlocks.Entities.Minecarts;

/// <summary>
/// Minecart with TNT
/// </summary>
public class ExplosiveMinecart : AbstractMinecart
{
    public override string Name => "Minecart TNT";

    public override VarInt Type => 56;

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.98, 0.7, 0.98);

    public override Identifier Identifier => new("tnt_minecart");
    public override void Spawn()
    {
        throw new NotImplementedException();
    }
}