using MinecraftTypes;
using SmartBlocks.Entities.Attributes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Monsters;

public class ZombifiedPiglin : Zombie
{
    public override string Name => "Zombified Piglin";

    public override VarInt Type => 110;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(0.6, 1.8, 0.6);

    public override Identifier Identifier => new("zombified_piglin");

    public void ApplyAttackSpeedBoost()
    {
        var mod = AttributeModifier.AttackingSpeedBoost;
        mod.Value = 0.45;
        Attributes["generic.movement_speed"].Modifiers.Add(mod);
    }
}