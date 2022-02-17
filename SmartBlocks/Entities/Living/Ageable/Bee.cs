using MinecraftTypes;
using SmartBlocks.Entities.Flags;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Bee : Animal
    {
        public override string Name => "Bee";

        public override VarInt Type => 5;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.7, 0.6, 0.7);

        public override Identifier Identifier => "bee";

        private byte _beeFlags = 0;

        public bool IsAngry
        {
            get => FlagsHelper.IsSet(_beeFlags, (byte) BeeFlag.Angry);
            set
            {
                if (value) FlagsHelper.Set(ref _beeFlags, (byte) BeeFlag.Angry);
                else FlagsHelper.Unset(ref _beeFlags, (byte) BeeFlag.Angry);
            }
        }

        public bool HasStung
        {
            get => FlagsHelper.IsSet(_beeFlags, (byte) BeeFlag.Stung);
            set
            {
                if (value) FlagsHelper.Set(ref _beeFlags, (byte) BeeFlag.Stung);
                else FlagsHelper.Unset(ref _beeFlags, (byte) BeeFlag.Stung);
            }
        }

        public bool HasNectar
        {
            get => FlagsHelper.IsSet(_beeFlags, (byte) BeeFlag.Nectar);
            set
            {
                if (value) FlagsHelper.Set(ref _beeFlags, (byte) BeeFlag.Nectar);
                else FlagsHelper.Unset(ref _beeFlags, (byte) BeeFlag.Nectar);
            }
        }

        public VarInt AngerTimeTicks { get; set; } = 0;
    }
}
