using MinecraftTypes;
using SmartBlocks.Entities.Flags;

namespace SmartBlocks.Entities.Living.Mobs
{
    public class SnowGolem : AbstractGolem
    {
        public override string Name => "Snow Golem";

        public override VarInt Type => 82;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.7, 1.9, 0.7);

        public override Identifier Identifier => new("snow_golem");

        private byte _hat = 0x10;

        public bool HasPumpkinHat
        {
            get => FlagsHelper.IsSet(_hat, (byte) SnowGolemFlag.HasHat);
            set
            {
                if (value) FlagsHelper.Set(ref _hat, (byte) SnowGolemFlag.HasHat);
                else FlagsHelper.Unset(ref _hat, (byte) SnowGolemFlag.HasHat);
            }
        }
    }
}
