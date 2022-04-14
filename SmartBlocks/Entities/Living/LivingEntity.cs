﻿using java.util;
using Medallion;
using MinecraftTypes;
using SmartBlocks.Blocks;
using SmartBlocks.Entities.Attributes;
using SmartBlocks.Entities.Flags;
using SmartBlocks.Entities.Living.Mobs;
using SmartBlocks.Entities.Living.Weapons;
using SmartBlocks.Utils;
using Random = System.Random;

namespace SmartBlocks.Entities.Living;

public class LivingEntity : Entity
{
    private byte _handStates = 0;

    public bool IsHandActive
    {
        get => FlagsHelper.IsSet(_handStates, (byte)HandStateFlag.HandActive);
        set
        {
            if (value) FlagsHelper.Set(ref _handStates, (byte)HandStateFlag.HandActive);
            else FlagsHelper.Unset(ref _handStates, (byte)HandStateFlag.HandActive);
        }
    }

    public bool OffHandIsActiveHand
    {
        get => FlagsHelper.IsSet(_handStates, (byte)HandStateFlag.ActiveHand);
        set
        {
            if (value) FlagsHelper.Set(ref _handStates, (byte)HandStateFlag.ActiveHand);
            else FlagsHelper.Unset(ref _handStates, (byte)HandStateFlag.HandActive);
        }
    }

    public bool MainHandIsActiveHand
    {
        get => !OffHandIsActiveHand;
        set => OffHandIsActiveHand = !value;
    }

    public bool IsInRiptideSpinAttack
    {
        get => FlagsHelper.IsSet(_handStates, (byte)HandStateFlag.RiptdeSpinAttack);
        set
        {
            if (value) FlagsHelper.Set(ref _handStates, (byte)HandStateFlag.RiptdeSpinAttack);
            else FlagsHelper.Unset(ref _handStates, (byte)HandStateFlag.RiptdeSpinAttack);
        }
    }

    public float Health { get; set; } = 1.0f;

    /// <summary>
    /// 0 if there is no effect.
    /// </summary>
    public VarInt PotionEffectColor { get; set; } = 0;

    /// <summary>
    /// Reduces the number of particles generated by potions to 1/5 the normal
    /// amount if set to true
    /// </summary>
    public bool IsPotionEffectAmbient { get; set; } = false;

    public VarInt NumberOfArrowsInEntity { get; set; } = 0;

    public VarInt NumberOfBeeStingers { get; set; } = 0;

    public OptBlockPos SleepingLocation { get; set; }

    public double MaxHealth
    {
        get => Attributes["generic.max_health"].Value;
        set
        {

            Attributes["generic.max_health"].Value = value;
        }
    }

    public double FollowRange
    {
        get => Attributes["generic.follow_range"].Value;
        set
        {
            Attributes["generic.follow_range"].Value = value;
        }
    }

    public void SetFollowRange(double value)
    {
        var mod = AttributeModifier.RandomSpawnBonusFollowRange;
        mod.Value = value;
        Attributes["generic.follow_range"].Modifiers.Add(mod);
    }

    public double KnockbackResistance
    {
        get => Attributes["generic.knockback_resistance"].Value;
        set
        {
            Attributes["generic.knockback_resistance"].Value = value;
        }
    }

    public double MovementSpeed
    {
        get => Attributes["generic.movement_speed"].Value;
        set
        {
            Attributes["generic.movement_speed"].Value = value;
        }
    }

    public double AttackDamage
    {
        get => Attributes["generic.attack_damage"].Value;
        set
        {
            Attributes["generic.attack_damage"].Value = value;
        }
    }

    public void SetAttackDamage(double damage)
    {
        var mod = AttributeModifier.ToolAttackDamage;
        mod.Value = damage;
        Attributes["generic.attack_damage"].Modifiers.Add(mod);
    }

    public void SetToolAttackDamage(EntityToolType toolType, byte attackVariant)
    {
        switch (toolType)
        {
            case EntityToolType.Trident:
                switch ((TridentDamageLevel)attackVariant)
                {
                    case TridentDamageLevel.Melee:
                        SetAttackDamage(9);
                        break;
                    case TridentDamageLevel.MeleeCritical:
                        SetAttackDamage(13.5);
                        break;
                    case TridentDamageLevel.Range:
                        SetAttackDamage(8);
                        break;
                }
                break;
            case EntityToolType.Shovel:
                switch ((MaterialType) attackVariant)
                {
                    case MaterialType.Wood:
                    case MaterialType.Gold:
                        SetAttackDamage(2.5);
                        break;
                    case MaterialType.Stone:
                        SetAttackDamage(3.5);
                        break;
                    case MaterialType.Iron:
                        SetAttackDamage(4.5);
                        break;
                    case MaterialType.Diamond:
                        SetAttackDamage(5.5);
                        break;
                    case MaterialType.Netherite:
                        SetAttackDamage(6.5);
                        break;
                }
                break;
            case EntityToolType.Pickaxe:
                switch ((MaterialType) attackVariant)
                {
                    case MaterialType.Wood:
                    case MaterialType.Gold:
                        SetAttackDamage(2);
                        break;
                    case MaterialType.Stone:
                        SetAttackDamage(3);
                        break;
                    case MaterialType.Iron:
                        SetAttackDamage(4);
                        break;
                    case MaterialType.Diamond:
                        SetAttackDamage(5);
                        break;
                    case MaterialType.Netherite:
                        SetAttackDamage(6);
                        break;
                }
                break;
            case EntityToolType.Axe:
                switch ((MaterialType)attackVariant)
                {
                    case MaterialType.Wood:
                    case MaterialType.Gold:
                        SetAttackDamage(7);
                        break;
                    case MaterialType.Stone:
                    case MaterialType.Iron:
                    case MaterialType.Diamond:
                        SetAttackDamage(9);
                        break;
                    case MaterialType.Netherite:
                        SetAttackDamage(10);
                        break;
                }
                break;
            case EntityToolType.Hoe:
                // Attack Variant is ignored on hoe.
                SetAttackDamage(1);
                break;
            case EntityToolType.Sword:
                switch ((MaterialType)attackVariant)
                {
                    case MaterialType.Wood:
                    case MaterialType.Gold:
                        SetAttackDamage(4);
                        break;
                    case MaterialType.Stone:
                        SetAttackDamage(5);
                        break;
                    case MaterialType.Iron:
                        SetAttackDamage(6);
                        break;
                    case MaterialType.Diamond:
                        SetAttackDamage(7);
                        break;
                    case MaterialType.Netherite:
                        SetAttackDamage(8);
                        break;
                }
                break;
        }
    }

    public double ArmorDefensePoints
    {
        get => Attributes["generic.armor"].Value;
        set
        {
            Attributes["generic.armor"].Value = value;
        }
    }

    public void SetArmorDefense(ArmorType type, ArmorPart part)
    {
        double value = 0;
        AttributeModifier mod = null!;
        switch (part)
        {
            case ArmorPart.Boots:
                mod = AttributeModifier.ArmorBoots;
                switch (type)
                {
                    case ArmorType.Leather:
                    case ArmorType.Gold:
                    case ArmorType.Chain:
                        value = 1;
                        break;
                    case ArmorType.Iron:
                        value = 2;
                        break;
                    case ArmorType.Diamond:
                    case ArmorType.Netherite:
                        value = 3;
                        break;
                }
                break;
            case ArmorPart.Legs:
                mod = AttributeModifier.ArmorLeggings;
                switch (type)
                {
                    case ArmorType.Leather:
                        value = 2;
                        break;
                    case ArmorType.Gold:
                        value = 3;
                        break;
                    case ArmorType.Chain:
                        value = 4;
                        break;
                    case ArmorType.Iron:
                        value = 5;
                        break;
                    case ArmorType.Diamond:
                    case ArmorType.Netherite:
                        value = 6;
                        break;
                }
                break;
            case ArmorPart.Chest:
                mod = AttributeModifier.ArmorChestPlate;
                switch (type)
                {
                    case ArmorType.Leather:
                        value = 3;
                        break;
                    case ArmorType.Gold:
                    case ArmorType.Chain:
                        value = 5;
                        break;
                    case ArmorType.Iron:
                        value = 6;
                        break;
                    case ArmorType.Diamond:
                    case ArmorType.Netherite:
                        value = 8;
                        break;
                }
                break;
            case ArmorPart.Helmet:
                mod = AttributeModifier.ArmorHelmet;
                switch (type)
                {
                    case ArmorType.Leather:
                        value = 1;
                        break;
                    case ArmorType.Gold:
                    case ArmorType.Chain:
                    case ArmorType.Iron:
                    case ArmorType.TurtleShell:
                        value = 2;
                        break;
                    case ArmorType.Diamond:
                    case ArmorType.Netherite:
                        value = 3;
                        break;
                }
                break;
        }

        mod.Value = value;
        Attributes["generic.attack_damage"].Modifiers.Add(mod);
    }

    public double ArmorToughness
    {
        get => Attributes["generic.armor_toughness"].Value;
        set
        {
            Attributes["generic.armor_toughness"].Value = value;
        }
    }

    public void SetArmorTougness(ArmorType type, ArmorPart part)
    {
        double value = 0;
        AttributeModifier mod = null!;
        switch (part)
        {
            case ArmorPart.Boots:
                mod = AttributeModifier.ArmorBootsToughness;
                switch (type)
                {
                    case ArmorType.Leather:
                        value = 65;
                        break;
                    case ArmorType.Gold:
                        value = 91;
                        break;
                    case ArmorType.Chain:
                    case ArmorType.Iron:
                        value = 195;
                        break;
                    case ArmorType.Diamond:
                        value = 429;
                        break;
                    case ArmorType.Netherite:
                        value = 481;
                        break;
                }
                break;
            case ArmorPart.Legs:
                mod = AttributeModifier.ArmorLeggingsToughness;
                switch (type)
                {
                    case ArmorType.Leather:
                        value = 75;
                        break;
                    case ArmorType.Gold:
                        value = 105;
                        break;
                    case ArmorType.Chain:
                    case ArmorType.Iron:
                        value = 225;
                        break;
                    case ArmorType.Diamond:
                        value = 495;
                        break;
                    case ArmorType.Netherite:
                        value = 555;
                        break;
                }
                break;
            case ArmorPart.Chest:
                mod = AttributeModifier.ArmorChestPlateToughness;
                switch (type)
                {
                    case ArmorType.Leather:
                        value = 80;
                        break;
                    case ArmorType.Gold:
                        value = 112;
                        break;
                    case ArmorType.Chain:
                    case ArmorType.Iron:
                        value = 240;
                        break;
                    case ArmorType.Diamond:
                        value = 528;
                        break;
                    case ArmorType.Netherite:
                        value = 592;
                        break;
                }
                break;
            case ArmorPart.Helmet:
                mod = AttributeModifier.ArmorHelmetToughness;
                switch (type)
                {
                    case ArmorType.Leather:
                        value = 55;
                        break;
                    case ArmorType.Gold:
                        value = 77;
                        break;
                    case ArmorType.Chain:
                    case ArmorType.Iron:
                        value = 165;
                        break;
                    case ArmorType.TurtleShell:
                        value = 275;
                        break;
                    case ArmorType.Diamond:
                        value = 363;
                        break;
                    case ArmorType.Netherite:
                        value = 407;
                        break;
                }
                break;
        }

        mod.Value = value;
        Attributes["generic.attack_damage"].Modifiers.Add(mod);
    }

    public double AttackKnockback
    {
        get => Attributes["generic.attack_knockback"].Value;
        set
        {
            Attributes["generic.attack_knockback"].Value = value;
        }
    }

    public void ApplyKnockbackResistance()
    {
        var mod = AttributeModifier.KnockbackResistance;
        mod.Value = 0.1;
        Attributes["generic.knockback_resistance"].Modifiers.Add(mod);
    }

    public void ApplySprintingSpeedBoost()
    {
        var mod = AttributeModifier.SprintingSpeedBoost;
        mod.Value = 0.3;
        Attributes["generic.movement_speed"].Modifiers.Add(mod);
    }

    public override void Spawn()
    {
        Attributes.Add(MobAttribute.MaxHealth);

        Attributes.Add(MobAttribute.FollowRange);
        SetFollowRange(new Random().NextDouble(0.0, 0.05));

        Attributes.Add(MobAttribute.KnockbackResistance);
        Attributes.Add(MobAttribute.MovementSpeed);
        Attributes.Add(MobAttribute.AttackDamage);
        Attributes.Add(MobAttribute.Armor);
        Attributes.Add(MobAttribute.ArmorToughness);
        Attributes.Add(MobAttribute.AttackKnockback);
    }

}