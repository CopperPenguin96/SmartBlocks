using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Tameable;

public class Cat : TameableAnimal
{
    public override string Name => "Cat";

    public override VarInt Type => 8;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.6, 0.7, 0.6);

    public override Identifier Identifier => "cat";

    public VarInt CatType { get; set; } = 1;

    public bool IsLying { get; set; } = false;

    public bool IsRelaxed { get; set; } = false;

    public VarInt CollarColor { get; set; } = 14;
    
}