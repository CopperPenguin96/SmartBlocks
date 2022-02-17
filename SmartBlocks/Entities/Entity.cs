using java.util;
using MinecraftTypes;
using SmartBlocks.Entities.Flags;
using SmartBlocks.Utils;

namespace SmartBlocks.Entities
{
    public class Entity
    {
        public VarInt Id { get; set; }

        public virtual VarInt Type { get; }

        public UUID UniqueId { get; set; }

        public virtual string Name => "Entity";
        
        internal virtual bool UseSpawnEntityOnly { get; }

        internal virtual bool UseSpawnPaintingOnly { get; }

        internal virtual bool UseSpawnXpOnly { get; }

        internal virtual bool AllowedSpawn { get; }

        public Position Velocity { get; set; }

        public PosDouble Position { get; set; }

        public byte HeadPitch { get; set; }

        public virtual BoundingBox BoundingBox { get; set; }

        public virtual Identifier Identifier { get; }

        public VarInt AirTicks { get; set; } = 300;

        // todo OptChatBuilder
        public OptObject<string> CustomName { get; set; }

        public bool IsCustomNameVisible { get; set; } = false;

        public bool IsSilent { get; set; } = false;

        public bool HasNoGravity { get; set; } = false;

        public Pose Pose { get; set; } = Pose.Standing;

        public VarInt TicksFrozenInPoweredSnow { get; set; } = 0;

        #region Flags

        private byte _entityMask = 0;

        public bool IsOnFire
        {
            get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.OnFire);
            set
            {
                if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.OnFire);
                else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.OnFire);
            }
        }

        public bool IsCrouching
        {
            get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.Crouching);
            set
            {
                if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.Crouching);
                else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.Crouching);
            }
        }

        public bool IsSprinting
        {
            get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.Sprinting);
            set
            {
                if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.Sprinting);
                else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.Sprinting);
            }
        }

        public bool IsSwimming
        {
            get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.Swimming);
            set
            {
                if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.Swimming);
                else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.Swimming);
            }
        }

        public bool IsInvisible
        {
            get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.Invisible);
            set
            {
                if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.Invisible);
                else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.Invisible);
            }
        }

        public bool HasGlowingEffect
        {
            get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.Glowing);
            set
            {
                if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.Glowing);
                else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.Glowing);
            }
        }

        public bool FlyingWithElytra
        {
            get => FlagsHelper.IsSet(_entityMask, (byte) EntityFlag.FlyingElytra);
            set
            {
                if (value) FlagsHelper.Set(ref _entityMask, (byte) EntityFlag.FlyingElytra);
                else FlagsHelper.Unset(ref _entityMask, (byte) EntityFlag.FlyingElytra);
            }
        }

        #endregion
    }
}
