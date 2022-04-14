using MinecraftTypes;

namespace SmartBlocks.Worlds;

public sealed class Structure
{
    public Identifier Id { get; }

    public StructSettings Settings { get; set; }

    private Structure(Identifier id)
    {
        Id = id;
    }

    public static implicit operator Structure(Identifier id)
    {
        return new(id);
    }

    public static implicit operator Structure(string id)
    {
        return new(id);
    }

    public static bool operator ==(Structure s1, Structure s2)
    {
        return s1.Id == s2.Id;
    }

    public static bool operator !=(Structure s1, Structure s2)
    {
        return !(s1 == s2);
    }

    public static readonly Structure AquaAffinity = "aqua_affinity";
    public static readonly Structure BaneOfArthropods = "bane_of_arthropods";
    public static readonly Structure CurseOfBinding = "curse_of_binding";
    public static readonly Structure BlastProtection = "blast_protection";
    public static readonly Structure Channeling = "channeling";
    public static readonly Structure DepthStrider = "depth_strider";
    public static readonly Structure Efficiency = "efficiency";
    public static readonly Structure FeatherFalling = "feather_falling";
    public static readonly Structure FireAspect = "fire_aspect";
    public static readonly Structure FireProtection = "fire_protection";
    public static readonly Structure Flame = "flame";
    public static readonly Structure Fortune = "fortune";
    public static readonly Structure FrostWalker = "frost_walker";
    public static readonly Structure Impaling = "impaling";
    public static readonly Structure Infinity = "infinity";
    public static readonly Structure Knockback = "knockback";
    public static readonly Structure Looting = "looting";
    public static readonly Structure Loyalty = "loyalty";
    public static readonly Structure LuckOfTheSea = "luck_of_the_sea";
    public static readonly Structure Lure = "lure";
    public static readonly Structure Mending = "mending";
    public static readonly Structure Multishot = "multishot";
    public static readonly Structure Piercing = "piercing";
    public static readonly Structure Power = "power";
    public static readonly Structure ProjectileProtection = "projectile_protection";
    public static readonly Structure Protection = "protection";
    public static readonly Structure Punch = "punch";
    public static readonly Structure QuickCharge = "quick_charge";
    public static readonly Structure Respiration = "respiration";
    public static readonly Structure Riptide = "riptide";
    public static readonly Structure Sharpness = "sharpness";
    public static readonly Structure SilkTouch = "silk_touch";
    public static readonly Structure Smite = "smite";
    public static readonly Structure SoulSpeed = "soul_speed";
    public static readonly Structure SweepingEdge = "sweeping";
    public static readonly Structure Thorns = "thorns";
    public static readonly Structure Unbreaking = "unbreaking";
    public static readonly Structure CurseOfVanishing = "vanishing_curse";
}

public class StructSettings
{
    public int Spacing { get; set; }

    public int Separation { get; set; }

    public int Salt { get; set; }
}