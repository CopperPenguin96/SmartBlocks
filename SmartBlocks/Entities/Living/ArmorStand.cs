using MinecraftTypes;
using SmartBlocks.Entities.Flags;

namespace SmartBlocks.Entities.Living
{
    public class ArmorStand : LivingEntity
    {
        public override string Name => "Armor Stand";

        public override VarInt Type => 1;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox
        {
            get
            {
                if (!IsMarker && !IsSmall) return new(0.5, 1.975, 0.5);
                if (IsMarker && !IsSmall) return new(0.0, 0.0, 0.0);
                if (!IsMarker && IsSmall) return new(0.25, 0.9875, 0.25);
                throw new Exception("Invalid Armor Stand");
            }
        }

        public override Identifier Identifier => "armor_stand";
        
        private byte _mask = 0;

        public bool IsSmall
        {
            get => FlagsHelper.IsSet(_mask, (byte) ArmorStandFlag.Small);
            set
            {
                if (value) FlagsHelper.Set(ref _mask, (byte) ArmorStandFlag.Small);
                else FlagsHelper.Unset(ref _mask, (byte) ArmorStandFlag.Small);
            }
        }

        public bool HasArms
        {
            get => FlagsHelper.IsSet(_mask, (byte) ArmorStandFlag.HasArms);
            set
            {
                if (value) FlagsHelper.Set(ref _mask, (byte) ArmorStandFlag.HasArms);
                else FlagsHelper.Unset(ref _mask, (byte) ArmorStandFlag.HasArms);
            }
        }

        public bool HasNoBasePlate
        {
            get => FlagsHelper.IsSet(_mask, (byte) ArmorStandFlag.NoBasePlate);
            set
            {
                if (value) FlagsHelper.Set(ref _mask, (byte) ArmorStandFlag.NoBasePlate);
                else FlagsHelper.Unset(ref _mask, (byte) ArmorStandFlag.NoBasePlate);
            }
        }

        public bool IsMarker
        {
            get => FlagsHelper.IsSet(_mask, (byte) ArmorStandFlag.Marker);
            set
            {
                if (value) FlagsHelper.Set(ref _mask, (byte) ArmorStandFlag.Marker);
                else FlagsHelper.Unset(ref _mask, (byte) ArmorStandFlag.Marker);
            }
        }

        public Rotation HeadRotation { get; set; } = new(0.0f, 0.0f, 0.0f);

        public Rotation BodyRotation { get; set; } = new(0.0f, 0.0f, 0.0f);

        public Rotation LeftArmRotation { get; set; } = new(-10.0f, 0.0f, -10.0f);

        public Rotation RightArmRotation { get; set; } = new(-15.0f, 0.0f, 10.0f);

        public Rotation LeftLegRotation { get; set; } = new(-1.0f, 0.0f, -1.0f);

        public Rotation RightLegRotation { get; set; } = new(1.0f, 0.0f, 1.0f);
    }
    
}
