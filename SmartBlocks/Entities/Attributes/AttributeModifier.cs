using java.util;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Attributes
{
    public class AttributeModifier
    {
        public ModifierOperation Operation { get; private set; }

        public double Value { get; set; }

        public string Name { get; internal set; }

        public UUID UniqueId { get; internal set; }

        private AttributeModifier(string name, ModifierOperation op, UUID uId = null!)
        {
            Name = name;
            Operation = op;

            if (uId == null) uId = UUID.randomUUID();
            UniqueId = uId;
        }

        public static readonly AttributeModifier RandomSpawnBonusFollowRange = new("Random spawn bonus", ModifierOperation.AddSubtractPercent);
        public static readonly AttributeModifier RandomSpawnBonusKnockback = new("Random spawn bonus", ModifierOperation.AddSubtract);
        public static readonly AttributeModifier ToolAttackDamage = new("Tool modifier", ModifierOperation.AddSubtract, Mob.ToolAttackDamageId);
        public static readonly AttributeModifier ToolAttackSpeed = new("Tool modifier", ModifierOperation.AddSubtract, Mob.ToolAttackSpeedId);
        public static readonly AttributeModifier ArmorBoots = new("Armor modifier", ModifierOperation.AddSubtract, Mob.ArmorBootId);
        public static readonly AttributeModifier ArmorLeggings = new("Armor modifier", ModifierOperation.AddSubtract, Mob.ArmorLeggingId);
        public static readonly AttributeModifier ArmorChestPlate = new("Armor modifier", ModifierOperation.AddSubtract, Mob.ArmorChestId);
        public static readonly AttributeModifier ArmorHelmet = new("Armor modifier", ModifierOperation.AddSubtract, Mob.ArmorHelmetId);
        public static readonly AttributeModifier ArmorBootsToughness = new("Armor toughness", ModifierOperation.AddSubtract, Mob.ArmorBootId);
        public static readonly AttributeModifier ArmorLeggingsToughness = new("Armor toughness", ModifierOperation.AddSubtract, Mob.ArmorLeggingId);
        public static readonly AttributeModifier ArmorChestPlateToughness = new("Armor toughness", ModifierOperation.AddSubtract, Mob.ArmorChestId);
        public static readonly AttributeModifier ArmorHelmetToughness = new("Armor toughness", ModifierOperation.AddSubtract, Mob.ArmorHelmetId);
        public static readonly AttributeModifier KnockbackResistance = new("Knockback resistance", ModifierOperation.AddSubtract, Mob.KnockbackId);
        public static readonly AttributeModifier SprintingSpeedBoost = new("Sprinting speed boost", ModifierOperation.PercMultiply, Mob.MovementSpeedId);
        public static readonly AttributeModifier FleeingSpeedBoost = new("Fleeing speed boost", ModifierOperation.PercMultiply, Mob.FleeingMovementSpeedId);
        public static readonly AttributeModifier AttackingSpeedBoost = new("Attacking speed boost", ModifierOperation.AddSubtract); // TODO - Set UUID for respective mob
        public static readonly AttributeModifier CoveredArmorBonus = new("Covered armor bonus", ModifierOperation.AddSubtract, Mob.ShulkerGenericArmorId);
        public static readonly AttributeModifier HorseArmorBonus = new("Horse armor bonus", ModifierOperation.AddSubtract, Mob.HorseGenericArmorId);
        public static readonly AttributeModifier BabySpeedBoost = new("Baby speed boost", ModifierOperation.AddSubtractPercent, Mob.BabyZombieMovementSpeedId);
        public static readonly AttributeModifier DrinkingSpeedPenalty = new("Drinking speed penalty", ModifierOperation.AddSubtract, Mob.WitchMovementSpeedId);
        public static readonly AttributeModifier RandomZombieSpawnBonus = new("Random zombie-spawn bonus", ModifierOperation.PercMultiply);
        public static readonly AttributeModifier LeaderZombieBonusSpawnReinfor = new("Leader zombie bonus", ModifierOperation.AddSubtract);
        public static readonly AttributeModifier LeaderZombieBonusSpawnMaxHealth = new("Leader zombie bonus", ModifierOperation.PercMultiply);
        public static readonly AttributeModifier ZombieReinforCallerCharge = new("Zombie reinforcement caller charge", ModifierOperation.AddSubtract);
        public static readonly AttributeModifier EffectMoveSpeed = new("effect.moveSpeed", ModifierOperation.PercMultiply, Mob.AllEntitiesMovementSpeedId);
        public static readonly AttributeModifier EffectMoveSlowdown = new("effect.moveSlowdown", ModifierOperation.PercMultiply, Mob.AllEntitiesMovementSpeed2Id);
        public static readonly AttributeModifier EffectDigSpeed = new("effect.digSpeed", ModifierOperation.PercMultiply, Mob.AllAttackSpeedId);
        public static readonly AttributeModifier EffectDigSlowDown = new("effect.digSlowDown", ModifierOperation.PercMultiply, Mob.AllAttackSpeed2Id);
        public static readonly AttributeModifier EffectDamageBoost = new("effect.damageBoost", ModifierOperation.AddSubtract, Mob.AllAttackDamageId);
        public static readonly AttributeModifier EffectWeakness = new("effect.weakness", ModifierOperation.AddSubtract, Mob.AllAttackDamage2Id);
        public static readonly AttributeModifier EffectHealthBoost = new("effect.healthBoost", ModifierOperation.AddSubtract, Mob.AllMaxHealthId);
        public static readonly AttributeModifier EffectLuck = new("effect.luck", ModifierOperation.AddSubtract, Mob.AllLuckId);
        public static readonly AttributeModifier EffectUnluck = new("effect.unluck", ModifierOperation.AddSubtract, Mob.AllLuck2Id);
    }
}
