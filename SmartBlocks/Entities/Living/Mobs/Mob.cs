using MinecraftTypes;
using SmartBlocks.Blocks;
using SmartBlocks.Entities.Flags;
using SmartBlocks.Utils;

namespace SmartBlocks.Entities.Living.Mobs
{
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


    }
}
