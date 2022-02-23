using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class ElderGuardian : Guardian
    {
        public override string Name => "Elder Guardian";

        public override VarInt Type => 18;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(1.9975, 1.9975, 1.9975);

        public override Identifier Identifier => "elder_guardian";
    }
}
