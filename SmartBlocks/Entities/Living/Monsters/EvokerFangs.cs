using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class EvokerFangs : Entity
    {
        public override string Name => "Evoker";

        public override VarInt Type => 24;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.5, 0.8, 0.5);

        public override Identifier Identifier => "evoker_fangs";
    }
}
