using java.util;
using Medallion;
using MinecraftTypes;
using SmartBlocks.Blocks;
using SmartBlocks.Entities.Attributes;
using SmartBlocks.Entities.Flags;
using SmartBlocks.Utils;
using SmartBlocks.Worlds;

namespace SmartBlocks.Entities.Living.Mobs;

public class Mob : LivingEntity
{
    private byte _mobMask = 0;

    public bool NoAi
    {
        get => FlagsHelper.IsSet(_mobMask, (byte) MobFlag.NoAi);
        set
        {
            if (value) FlagsHelper.Set(ref _mobMask, (byte) MobFlag.NoAi);
            else FlagsHelper.Unset(ref _mobMask, (byte) MobFlag.NoAi);
        }
    }

    public bool IsLeftHanded
    {
        get => FlagsHelper.IsSet(_mobMask, (byte) MobFlag.LeftHanded);
        set
        {
            if (value) FlagsHelper.Set(ref _mobMask, (byte) MobFlag.LeftHanded);
            else FlagsHelper.Unset(ref _mobMask, (byte) MobFlag.LeftHanded);
        }
    }

    public bool IsAggressive
    {
        get => FlagsHelper.IsSet(_mobMask, (byte) MobFlag.Aggressive);
        set
        {
            if (value) FlagsHelper.Set(ref _mobMask, (byte) MobFlag.Aggressive);
            else FlagsHelper.Unset(ref _mobMask, (byte) MobFlag.Aggressive);
        }
    }

    public float AbsorptionAmount { get; set; }

    public List<PotionEffect> PotionEffects { get; set; }

    public List<ArmorDropChance> ArmorDropChances { get; set; }

    public Slot ArmorFeet { get; set; }

    public Slot ArmorLeg { get; set; }

    public Slot ArmorChest { get; set; }

    public Slot ArmorHead { get; set; }

    public void ApplySpeedBoost()
    {
        if (IsAggressive) throw new Exception("Cannot be used on non-passive mobs.");
        var mod = AttributeModifier.FleeingSpeedBoost;
        mod.Value = 2;
        Attributes["generic.movement_speed"].Modifiers.Add(mod);
    }

    #region Id's

    public static readonly UUID ToolAttackDamageId =
        UUID.fromString("CB3F55D3-645C-4F38-A497-9C13A33DB5CF");

    public static readonly UUID ToolAttackSpeedId =
        UUID.fromString("FA233E1C-4180-4865-B01B-BCCE9785ACA3");

    public static readonly UUID ArmorBootId =
        UUID.fromString("845DB27C-C624-495F-8C9F-6020A9A58B6B");

    public static readonly UUID ArmorLeggingId =
        UUID.fromString("D8499B04-0E66-4726-AB29-64469D734E0D");

    public static readonly UUID ArmorChestId =
        UUID.fromString("9F3D476D-C118-4544-8365-64846904B48E");

    public static readonly UUID ArmorHelmetId =
        UUID.fromString("2AD3F246-FEE1-4E67-B886-69FD380BB150");

    public static readonly UUID KnockbackId =
        UUID.fromString("0-1-438d-0-28d34");

    public static readonly UUID MovementSpeedId =
        UUID.fromString("662A6B8D-DA3E-4C1C-8813-96EA6097278D");

    public static readonly UUID FleeingMovementSpeedId =
        UUID.fromString("E199AD21-BA8A-4C53-8D13-6182D5C69D3A");

    public static readonly UUID AttackingEndermenMovementSpeedId =
        UUID.fromString("020E0DFB-87AE-4653-9556-831010E291A0");

    public static readonly UUID AttackingPiglinZombMovementSpeedId =
        UUID.fromString("49455A49-7EC5-45BA-B886-3B90B23A1718");

    public static readonly UUID ShulkerGenericArmorId =
        UUID.fromString("7E0292F2-9434-48D5-A29F-9583AF7DF27F");

    public static readonly UUID HorseGenericArmorId =
        UUID.fromString("556E1665-8B10-40C8-8F9D-CF9B1667F295");

    public static readonly UUID BabyZombieMovementSpeedId =
        UUID.fromString("B9766B59-9566-4402-BC1F-2EE2A276D836");

    public static readonly UUID WitchMovementSpeedId =
        UUID.fromString("5CD17E52-A79A-43D3-A529-90FDE04B181E");

    public static readonly UUID AllEntitiesMovementSpeedId =
        UUID.fromString("91AEAA56-376B-4498-935B-2F7F68070635");

    public static readonly UUID AllEntitiesMovementSpeed2Id =
        UUID.fromString("7107DE5E-7CE8-4030-940E-514C1F160890");

    public static readonly UUID AllAttackSpeedId =
        UUID.fromString("AF8B6E3F-3328-4C0A-AA36-5BA2BB9DBEF3");

    public static readonly UUID AllAttackSpeed2Id =
        UUID.fromString("55FCED67-E92A-486E-9800-B47F202C4386");

    public static readonly UUID AllAttackDamageId =
        UUID.fromString("648D7064-6A60-4F59-8ABE-C2C23A6DD7A9");

    public static readonly UUID AllAttackDamage2Id =
        UUID.fromString("22653B89-116E-49DC-9B6B-9971489B5BE5");

    public static readonly UUID AllMaxHealthId =
        UUID.fromString("5D6F0BA2-1186-46AC-B896-C61C5CEE99CC");

    public static readonly UUID AllLuckId =
        UUID.fromString("03C3C89D-7037-4B42-869F-B146BCB64D2E");

    public static readonly UUID AllLuck2Id =
        UUID.fromString("CC5AF142-2BD2-4215-B636-2605AED11727");

    #endregion
}