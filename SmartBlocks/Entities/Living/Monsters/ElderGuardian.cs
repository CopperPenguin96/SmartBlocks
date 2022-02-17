using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class ElderGuardian : Guardian
    {
        public override string Name => "Elder Guardian";

        public override VarInt Type => 18;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.9975, 1.9975, 1.9975);

        public override Identifier Identifier => "elder_guardian";
    }
}
