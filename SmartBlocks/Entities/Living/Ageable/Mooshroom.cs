using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Ageable;

public class Mooshroom : Cow
{
    public override string Name => "Mooshroom";

    public override VarInt Type => 58;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.9, 1.4, 0.9);

    public override Identifier Identifier => new("mooshroom");

    public string Variant { get; set; } = "red";
    
}