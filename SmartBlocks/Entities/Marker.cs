using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class Marker : Entity
    {
        public override string Name => "Marker";

        public override VarInt Type => 49;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => false;

        public override BoundingBox BoundingBox => new(0, 0, 0);

        public override Identifier Identifier => new("marker");
    }
}
