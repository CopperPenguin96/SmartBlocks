using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class EvokerFangs : Entity
    {
        public override string Name => "Evoker";

        public override VarInt Type => 24;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.5, 0.8, 0.5);

        public override Identifier Identifier => "evoker_fangs";
    }
}
