using MinecraftTypes;

namespace SmartBlocks.Entities.Arrows;

public class SpectralArrow : AbstractArrow
{
    public override string Name => "Spectral Arrow";

    public override VarInt Type => 84;

    public override bool UseSpawnEntityOnly => true;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.5, 0.5, 0.5);

    public override Identifier Identifier => new("spectral_arrow");
}