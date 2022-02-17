using MinecraftTypes;
using SmartBlocks.Entities.Living.Mobs;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Slime : Mob
    {
        public override string Name => "Slime";

        public override VarInt Type => 80;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        private const double Multiplier = 0.51000005;

        public override BoundingBox BoundingBox => new(
            Multiplier * Size, Multiplier * Size, Multiplier * Size
        );

        public override Identifier Identifier => new("slime");

        public VarInt Size { get; set; }
    }
}
