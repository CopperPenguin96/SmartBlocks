using MinecraftTypes;
using SmartBlocks.Entities;
using SmartBlocks.Entities.Living;
using SmartBlocks.Utils;
using SmartNbt.Tags;

// ReSharper disable once CheckNamespace
namespace Redstone.Players
{
    public partial class Player : LivingEntity
    {
        public override string Name => "Player";

        public override VarInt Type => 111;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => false;

        public override BoundingBox BoundingBox => new(0.6, 1.8, 0.6);

        public override Identifier Identifier => new("player");

        public float AdditionalHearts { get; set; } = 0.0f;

        public VarInt Score { get; set; } = 0;

        private byte _skinParts = 0;

        public bool HatEnabled
        {
            get => FlagsHelper.IsSet(_skinParts, (byte) SkinPart.HatEnabled);
            set
            {
                if (value) FlagsHelper.Set(ref _skinParts, (byte) SkinPart.HatEnabled);
                else FlagsHelper.Unset(ref _skinParts, (byte) SkinPart.HatEnabled);
            }
        }

        public bool CapeEnabled
        {
            get => FlagsHelper.IsSet(_skinParts, (byte) SkinPart.CapeEnabled);
            set
            {
                if (value) FlagsHelper.Set(ref _skinParts, (byte) SkinPart.CapeEnabled);
                else FlagsHelper.Unset(ref _skinParts, (byte) SkinPart.CapeEnabled);
            }
        }

        public bool JacketEnabled
        {
            get => FlagsHelper.IsSet(_skinParts, (byte) SkinPart.JacketEnabled);
            set
            {
                if (value) FlagsHelper.Set(ref _skinParts, (byte) SkinPart.JacketEnabled);
                else FlagsHelper.Unset(ref _skinParts, (byte) SkinPart.JacketEnabled);
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
            get => FlagsHelper.IsSet(_skinParts, (byte) SkinPart.RightSleeveEnabled);
            set
            {
                if (value) FlagsHelper.Set(ref _skinParts, (byte) SkinPart.RightSleeveEnabled);
                else FlagsHelper.Unset(ref _skinParts, (byte) SkinPart.RightSleeveEnabled);
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
    }
}
