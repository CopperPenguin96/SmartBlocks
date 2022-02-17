using MinecraftTypes;
using SmartBlocks.Entities.Flags;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Sheep : Animal
    {
        public override string Name => "Sheep";

        public override VarInt Type => 74;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.9, 1.3, 0.9);

        public override Identifier Identifier => new("sheep");

        private byte _sheep = 0;

        public bool IsSheared
        {
            get => FlagsHelper.IsSet(_sheep, (byte)SheepFlag.Sheared);
            set
            {
                if (value) FlagsHelper.Set(ref _sheep, (byte)SheepFlag.Sheared);
                else FlagsHelper.Unset(ref _sheep, (byte)SheepFlag.Sheared);
            }
        }

        private byte _color = 0x0F;
        public SheepColor Color
        {
            get
            {
                if (FlagsHelper.IsSet(_color, (byte) SheepColor.White))
                    return SheepColor.White;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Orange))
                    return SheepColor.Orange;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Magenta))
                    return SheepColor.Magenta;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.LightBlue))
                    return SheepColor.LightBlue;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Yellow))
                    return SheepColor.Yellow;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Lime))
                    return SheepColor.Lime;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Pink))
                    return SheepColor.Pink;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Gray))
                    return SheepColor.Gray;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.LightGray))
                    return SheepColor.LightGray;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Cyan))
                    return SheepColor.Cyan;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Purple))
                    return SheepColor.Purple;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Blue))
                    return SheepColor.Blue;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Brown))
                    return SheepColor.Brown;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Green))
                    return SheepColor.Green;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Red))
                    return SheepColor.Red;
                if (FlagsHelper.IsSet(_color, (byte)SheepColor.Black))
                    return SheepColor.Black;

                return SheepColor.White;
            }
            set
            {
                FlagsHelper.Set(ref _color, (byte) value);
                FlagsHelper.Set(ref _sheep, _color);
            }
        }
    }

    public enum SheepColor : byte
    {
        White = 0,
        Orange = 1,
        Magenta = 2,
        LightBlue = 3,
        Yellow = 4,
        Lime = 5,
        Pink = 6,
        Gray = 7,
        LightGray = 8,
        Cyan = 9,
        Purple = 10,
        Blue = 11,
        Brown = 12,
        Green = 13,
        Red = 14,
        Black = 15
    }
}
