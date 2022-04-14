using java.util;
using Medallion;
using MinecraftTypes;
using SmartBlocks.Entities.Attributes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Monsters;

public class Zombie : Monster
{
    public override string Name => "Zombie";

    public override VarInt Type => 107;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.6, 1.95, 0.6);

    public override Identifier Identifier => new("zombie");

    public bool IsBaby { get; set; } = false;

    public VarInt Unused { get; set; } = 0; // Previously type

    public bool IsBecomingDrowned { get; set; } = false;

    public void SetKnockbackResistance(double value)
    {
        var mod = AttributeModifier.RandomSpawnBonusKnockback;
        mod.Value = value;
        Attributes["generic.knockback_resistance"].Modifiers.Add(mod);
    }

    public double SpawnHelpChance
    {
        get => Attributes["zombie.spawn_reinforcements"].Value;
        set
        {
            Attributes["zombie.spawn_reinforcements"].Value = value;
        }
    }

    public override void Spawn()
    {
        base.Spawn();
        Attributes.Add(MobAttribute.ZombieSpawnReinforcements);

        SetKnockbackResistance(new System.Random().NextDouble(0.0, 0.05));
    }
}