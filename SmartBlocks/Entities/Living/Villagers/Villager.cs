using Medallion;
using MinecraftTypes;
using SmartBlocks.Entities.Attributes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Villagers;

public class Villager : AbstractVillager
{
    public override string Name => "Villager";

    public override VarInt Type => 98;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.6, 1.95, 0.6);

    public override Identifier Identifier => new("villager");

    public VillagerData Data { get; set; }
        = new(VillagerType.Plains, VillagerJob.None, 1);

    public void SetKnockbackResistance(double value)
    {
        var mod = AttributeModifier.RandomSpawnBonusKnockback;
        mod.Value = value;
        Attributes["generic.knockback_resistance"].Modifiers.Add(mod);
    }

    public override void Spawn()
    {
        base.Spawn();
        SetKnockbackResistance(new Random().NextDouble(0.0, 0.05));
    }

}