using MinecraftTypes;
using SmartBlocks.Entities.Flags;
using SmartBlocks.Utils;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Vex : Monster
    {
        public override string Name => "Vex";

        public override VarInt Type => 97;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.4, 0.8, 0.4);

        public override Identifier Identifier => new("vex");

        private byte _vex = 0;

        public bool IsAttacking
        {
            get => FlagsHelper.IsSet(_vex, (byte) VexFlag.Attacking);
            set
            {
                if (value) FlagsHelper.Set(ref _vex, (byte) VexFlag.Attacking);
                else FlagsHelper.Unset(ref _vex, (byte) VexFlag.Attacking);
            }
        }
    }
}
