using MinecraftTypes;
using SmartBlocks.Blocks;
using SmartBlocks.Entities.Attributes;
using SmartBlocks.Entities.Living.Mobs;
using SmartBlocks.Entities.Living.Weapons;
using SmartBlocks.Utils;
using SmartNbt.Tags;

namespace SmartBlocks.Entities.Living;

public class PlayerEntity : LivingEntity
{
    public override string Name => "Player";

    public override VarInt Type => 111;

    public override bool UseSpawnEntityOnly => false;

    public override bool UseSpawnPaintingOnly => false;

    public override bool UseSpawnXpOnly => false;

    public override bool AllowedSpawn => false;

    public override BoundingBox BoundingBox => new(0.6, 1.8, 0.6);

    public override Identifier Identifier => new("player");

    public float AdditionalHearts { get; set; } = 0.0f;

    public VarInt Score { get; set; } = 0;

    private byte _skinParts = 0;

    public bool HatEnabled
    {
        get => FlagsHelper.IsSet(_skinParts, (byte)SkinPart.HatEnabled);
        set
        {
            if (value) FlagsHelper.Set(ref _skinParts, (byte)SkinPart.HatEnabled);
            else FlagsHelper.Unset(ref _skinParts, (byte)SkinPart.HatEnabled);
        }
    }

    public bool CapeEnabled
    {
        get => FlagsHelper.IsSet(_skinParts, (byte)SkinPart.CapeEnabled);
        set
        {
            if (value) FlagsHelper.Set(ref _skinParts, (byte)SkinPart.CapeEnabled);
            else FlagsHelper.Unset(ref _skinParts, (byte)SkinPart.CapeEnabled);
        }
    }

    public bool JacketEnabled
    {
        get => FlagsHelper.IsSet(_skinParts, (byte)SkinPart.JacketEnabled);
        set
        {
            if (value) FlagsHelper.Set(ref _skinParts, (byte)SkinPart.JacketEnabled);
            else FlagsHelper.Unset(ref _skinParts, (byte)SkinPart.JacketEnabled);
        }
    }

    public bool LeftSleeveEnabled
    {
        get => FlagsHelper.IsSet(_skinParts, (byte)SkinPart.LeftSleeveEnabled);
        set
        {
            if (value) FlagsHelper.Set(ref _skinParts, (byte)SkinPart.LeftSleeveEnabled);
            else FlagsHelper.Unset(ref _skinParts, (byte)SkinPart.LeftSleeveEnabled);
        }
    }

    public bool RightSleeveEnabled
    {
        get => FlagsHelper.IsSet(_skinParts, (byte)SkinPart.RightSleeveEnabled);
        set
        {
            if (value) FlagsHelper.Set(ref _skinParts, (byte)SkinPart.RightSleeveEnabled);
            else FlagsHelper.Unset(ref _skinParts, (byte)SkinPart.RightSleeveEnabled);
        }
    }

    public bool LeftPantsEnabled
    {
        get => FlagsHelper.IsSet(_skinParts, (byte)SkinPart.LeftPantsEnabled);
        set
        {
            if (value) FlagsHelper.Set(ref _skinParts, (byte)SkinPart.LeftPantsEnabled);
            else FlagsHelper.Unset(ref _skinParts, (byte)SkinPart.LeftPantsEnabled);
        }
    }

    public bool RightPantsEnabled
    {
        get => FlagsHelper.IsSet(_skinParts, (byte)SkinPart.RightPantsEnabled);
        set
        {
            if (value) FlagsHelper.Set(ref _skinParts, (byte)SkinPart.RightPantsEnabled);
            else FlagsHelper.Unset(ref _skinParts, (byte)SkinPart.RightPantsEnabled);
        }
    }

    /// <summary>
    /// 0 if left, 1 if right.
    /// </summary>
    public byte MainHand { get; set; } = 1;

    public NbtCompound LeftShouldData { get; set; }

    public NbtCompound RightShouldData { get; set; }

    public double AttackSpeed
    {
        get => Attributes["generic.attack_speed"].Value;
        set
        {
            Attributes["generic.attack_speed"].Value = value;
        }
    }

    public void SetAttackSpeed(double speed)
    {
        var mod = AttributeModifier.ToolAttackSpeed;
        mod.Value = speed;
        Attributes["generic.attack_speed"].Modifiers.Add(mod);
    }

    public void SetToolAttackSpeed(EntityToolType toolType, byte attackVariant)
    {
        switch (toolType)
        {
            case EntityToolType.Trident:
                SetAttackSpeed(1.1);
                break;
            case EntityToolType.Shovel:
                // All shovels have the same attack speed
                SetAttackSpeed(1);
                break;
            case EntityToolType.Pickaxe:
                // All pickaxes have the same attack speed
                SetAttackSpeed(1.2);
                break;
            case EntityToolType.Axe:
                switch ((MaterialType)attackVariant)
                {
                    case MaterialType.Wood:
                        SetAttackSpeed(0.8);
                        break;
                    case MaterialType.Gold:
                        SetAttackSpeed(1.0);
                        break;
                    case MaterialType.Stone:
                        SetAttackSpeed(0.8);
                        break;
                    case MaterialType.Iron:
                        SetAttackSpeed(0.9);
                        break;
                    case MaterialType.Diamond:
                    case MaterialType.Netherite:
                        SetAttackSpeed(1.0);
                        break;
                }
                break;
            case EntityToolType.Hoe:
                switch ((MaterialType)attackVariant)
                {
                    case MaterialType.Wood:
                    case MaterialType.Gold:
                        SetAttackSpeed(1);
                        break;
                    case MaterialType.Stone:
                        SetAttackSpeed(2);
                        break;
                    case MaterialType.Iron:
                        SetAttackSpeed(3);
                        break;
                    case MaterialType.Diamond:
                    case MaterialType.Netherite:
                        SetAttackSpeed(4);
                        break;
                }
                break;
            case EntityToolType.Sword:
                SetAttackSpeed(1.6);
                break;
        }
    }

    public double Luck
    {
        get => Attributes["generic.luck"].Value;
        set
        {
            Attributes["generic.luck"].Value = value;
        }
    }

    public override void Spawn()
    {
        base.Spawn();
        Attributes.Add(MobAttribute.AttackSpeed);
        Attributes.Add(MobAttribute.Luck);
    }

}