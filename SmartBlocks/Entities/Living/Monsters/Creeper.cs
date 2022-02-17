using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Creeper : Monster
    {
        public override string Name => "Creeper";

        public override VarInt Type => 13;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 1.7, 0.6);

        public override Identifier Identifier => "creeper";

        public CreeperState State { get; set; } = CreeperState.Idle;

        public bool IsCharged { get; set; } = false;

        public bool IsIgnited { get; set; } = false;
    }

    public enum CreeperState
    {
        Idle = -1,
        Fuse = 1
    }
}
