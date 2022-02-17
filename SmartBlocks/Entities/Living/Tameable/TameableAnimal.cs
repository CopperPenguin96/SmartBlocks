﻿using java.util;
using MinecraftTypes;
using SmartBlocks.Entities.Living.Ageable;

namespace SmartBlocks.Entities.Living.Tameable
{
    public class TameableAnimal : Animal
    {
        private byte _animal = 0;

        public bool IsSitting
        {
            get => FlagsHelper.IsSet(_animal, (byte) TameableFlag.Sitting);
            set
            {
                if (value) FlagsHelper.Set(ref _animal, (byte) TameableFlag.Sitting);
                else FlagsHelper.Unset(ref _animal, (byte) TameableFlag.Sitting);
            }
        }

        public bool IsTamed
        {
            get => FlagsHelper.IsSet(_animal, (byte)TameableFlag.Tamed);
            set
            {
                if (value) FlagsHelper.Set(ref _animal, (byte)TameableFlag.Tamed);
                else FlagsHelper.Unset(ref _animal, (byte)TameableFlag.Tamed);
            }
        }

        public OptObject<UUID> Owner { get; set; }
    }

    public enum TameableFlag : byte
    {
        Sitting = 0x01,
        Unused = 0x02,
        Tamed = 0x04
    }
}