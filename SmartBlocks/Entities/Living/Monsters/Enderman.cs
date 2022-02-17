using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Enderman : Monster
    {
        public override string Name => "Enderman";

        public override VarInt Type => 21;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 2.9, 0.6);

        public override Identifier Identifier => "enderman";

        public OptObject<VarInt> CarriedBlock { get; set; }

        public bool IsScreaming { get; set; } = false;

        public bool IsStaring { get; set; } = false;
    }
}
