using MinecraftTypes;
using SmartBlocks.Entities.Attributes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Tameable;

public class Parrot : TameableAnimal
{
    public override string Name => "Parrot";

    public override VarInt Type => 62;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.5, 0.9, 0.5);

    public override Identifier Identifier => new("parrot");

    public VarInt Variant { get; set; } = 0;

    public double FlyingSpeed
    {
        get => Attributes["generic.flying_speed"].Value;
        set
        {
            Attributes["generic.flying_speed"].Value = value;
        }
    }

    public override void Spawn()
    {
        base.Spawn();
        Attributes.Add(MobAttribute.FlyingSpeed);
    }

}