using java.util;
using MinecraftTypes;
using SmartBlocks.Utils;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Fox : Animal
    {
        public override string Name => "Fox";

        public override VarInt Type => 29;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 0.7, 0.6);

        public override Identifier Identifier => new("fox");

        public VarInt FoxType { get; set; } = 0;

        private byte _fox;

        public bool IsSitting
        {
            get => FlagsHelper.IsSet(_fox, (byte) FoxFlag.Sitting);
            set
            {
                if (value) FlagsHelper.Set(ref _fox, (byte) FoxFlag.Sitting);
                else FlagsHelper.Unset(ref _fox, (byte) FoxFlag.Sitting);
            }
        }

        public new bool IsCrouching
        {
            get => FlagsHelper.IsSet(_fox, (byte) FoxFlag.Crouching);
            set
            {
                if (value) FlagsHelper.Set(ref _fox, (byte) FoxFlag.Crouching);
                else FlagsHelper.Unset(ref _fox, (byte) FoxFlag.Crouching);
            }
        }

        public bool IsInterested
        {
            get => FlagsHelper.IsSet(_fox, (byte) FoxFlag.Interested);
            set
            {
                if (value) FlagsHelper.Set(ref _fox, (byte) FoxFlag.Interested);
                else FlagsHelper.Unset(ref _fox, (byte) FoxFlag.Interested);
            }
        }

        public bool IsPouncing
        {
            get => FlagsHelper.IsSet(_fox, (byte)FoxFlag.Pouncing);
            set
            {
                if (value) FlagsHelper.Set(ref _fox, (byte)FoxFlag.Pouncing);
                else FlagsHelper.Unset(ref _fox, (byte)FoxFlag.Pouncing);
            }
        }

        public bool IsSleeping
        {
            get => FlagsHelper.IsSet(_fox, (byte)FoxFlag.Sleeping);
            set
            {
                if (value) FlagsHelper.Set(ref _fox, (byte)FoxFlag.Sleeping);
                else FlagsHelper.Unset(ref _fox, (byte)FoxFlag.Sleeping);
            }
        }

        public bool IsFaceplanted
        {
            get => FlagsHelper.IsSet(_fox, (byte) FoxFlag.Faceplanted);
            set
            {
                if (value) FlagsHelper.Set(ref _fox, (byte) FoxFlag.Faceplanted);
                else FlagsHelper.Unset(ref _fox, (byte) FoxFlag.Faceplanted);
            }
        }

        public bool IsDefending
        {
            get => FlagsHelper.IsSet(_fox, (byte)FoxFlag.Defending);
            set
            {
                if (value) FlagsHelper.Set(ref _fox, (byte)FoxFlag.Defending);
                else FlagsHelper.Unset(ref _fox, (byte)FoxFlag.Defending);
            }
        }

        public OptObject<UUID> FirstUniqueId { get; set; }

        public OptObject<UUID> SecondUniqueId { get; set; }
    }

    public enum FoxVariant
    {
        Red = 0,
        Snow = 1
    }

    public enum FoxFlag
    {
        Sitting = 0x01,
        Unused = 0x02,
        Crouching = 0x04,
        Interested = 0x08,
        Pouncing = 0x10,
        Sleeping = 0x20,
        Faceplanted = 0x40,
        Defending = 0x80
    }
}
