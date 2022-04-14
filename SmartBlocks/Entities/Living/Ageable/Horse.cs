using Medallion;
using MinecraftTypes;
using SmartBlocks.Entities.Attributes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Ageable;

public class Horse : AbstractHorse
{
    public override string Name => "oHrse";

    public override VarInt Type => 37;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => true;

    public override BoundingBox BoundingBox => new(1.39648, 1.6, 1.39648);

    public override Identifier Identifier => new("horse");

    public VarInt Variant { get; set; } = 0;

    public ArmorType ArmorType { get; set; }

    public double JumpStrength
    {
        get => Attributes["horse.jump_strength"].Value;
        set
        {
            Attributes["horse.jump_strength"].Value = value;
        }
    }

    public override void Spawn()
    {
        base.Spawn();
        Attributes.Add(MobAttribute.HorseJumpStrength);
    }

    public void ApplyArmorBonus()
    {
        var mod = AttributeModifier.HorseArmorBonus;

        switch (ArmorType)
        {
            case ArmorType.Iron:
                mod.Value = 5;
                break;
            case ArmorType.Gold:
                mod.Value = 7;
                break;
            case ArmorType.Diamond:
                mod.Value = 11;
                break;
            default:
                mod.Value = 0;
                break;
        }

        Attributes["generic.movement_speed"].Modifiers.Add(mod);
    }
}