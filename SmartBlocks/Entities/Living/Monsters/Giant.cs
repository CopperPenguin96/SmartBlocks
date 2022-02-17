using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Giant : Monster
    {
        public override string Name => "Giant";

        public override VarInt Type => 31;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(3.6, 12.0, 3.6);

        public override Identifier Identifier => new("giant");
    }
}
