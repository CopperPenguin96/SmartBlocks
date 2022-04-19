using java.util;
using Medallion;
using MinecraftTypes;
using SmartBlocks.Entities.Attributes;
using SmartBlocks.Entities.Living.Mobs;
using Random = System.Random;

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

    public void BoostBabySpeed()
    {
        if (!IsBaby) throw new Exception("Can only be used on baby zombie's.");
        var mod = AttributeModifier.BabySpeedBoost;
        mod.Value = 0.5;
        Attributes["generic.movement_speed"].Modifiers.Add(mod);
    }

    public void SetSpawnBonus()
    {
        Random rnd = new Random();
        var mod = AttributeModifier.RandomSpawnBonusFollowRange;
        mod.Value = rnd.NextDouble(0.0, 1.5);
        Attributes["generic.follow_range"].Modifiers.Add(mod);

        mod = AttributeModifier.LeaderZombieBonusSpawnReinfor;
        mod.Value = rnd.NextDouble(0.5, 0.75);
        Attributes["zombie.spawn_reinforcements"].Modifiers.Add(mod);

        mod = AttributeModifier.LeaderZombieBonusSpawnMaxHealth;
        mod.Value = rnd.NextDouble(1.0, 4.0);
        Attributes["generic.max_health"].Modifiers.Add(mod);
    }

    public void SetCallerCharge()
    {
        var mod = AttributeModifier.ZombieReinforCallerCharge;
        mod.Value = -0.05;
        Attributes["zombie.spawn_reinforcements"].Modifiers.Add(mod);
    }

    public override void Spawn()
    {
        base.Spawn();
        Attributes.Add(MobAttribute.ZombieSpawnReinforcements);

        SetKnockbackResistance(new Random().NextDouble(0.0, 0.05));
        SetSpawnBonus();
    }
}