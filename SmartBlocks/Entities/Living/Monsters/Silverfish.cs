using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Silverfish : Monster
    {
        public override string Name => "Silverfish";

        public override VarInt Type => 77;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.4, 0.3, 0.4);

        public override Identifier Identifier => new("silverfis");
    }
}
