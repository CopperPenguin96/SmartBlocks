using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Attributes
{
    public class MobAttribute
    {
        public Identifier Name { get; private set; }

        public double Base { get; internal set; }

        public double Min { get; private set; }

        public double Max { get; private set; }

        public double Value { get; set; }

        public List<AttributeModifier> Modifiers { get; set; }

        private MobAttribute(string name, double baseD, double min, double max)
        {
            Name = name;
            Base = baseD;
            Min = min;
            Max = max;
        }

        public static readonly MobAttribute MaxHealth = new("generic.max_health", 20.0, 0.0, 1024.0);
        public static readonly MobAttribute FollowRange = new("generic.follow_range", 0.0, 0.0, 1.0);
        public static readonly MobAttribute KnockbackResistance = new("generic.knockback_resistance", 0.0, 0.0, 1.0);
        public static readonly MobAttribute MovementSpeed = new("generic.movement_speed", 0.7, 0.0, 1024.0);
        public static readonly MobAttribute AttackDamage = new("generic.attack_damage", 2.0, 0.0, 2048.0);
        public static readonly MobAttribute Armor = new("generic.armor", 0.0, 0.0, 30.0);
        public static readonly MobAttribute ArmorToughness = new("generic.armor_toughness", 0.0, 0.0, 20.0);
        public static readonly MobAttribute AttackKnockback = new("generic.attack_knockback", 0.0, 0.0, 5.0);
        public static readonly MobAttribute AttackSpeed = new("generic.attack_speed", 4.0, 0.0, 1024.0);
        public static readonly MobAttribute Luck = new("generic.luck", 0.0, -1024.0, 1024.0);
        public static readonly MobAttribute HorseJumpStrength = new("horse.jump_stength", 0.7, 0.0, 2.0);
        public static readonly MobAttribute FlyingSpeed = new("generic.flying_speed", 0.4, 0.0, 1024.0);
        public static readonly MobAttribute ZombieSpawnReinforcements = new("zombie.spawn_reinforcements", 0.0, 0.0, 1.0);


    }
}
