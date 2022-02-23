using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Husk : Zombie
    {
        public override string Name => "Husk";

        public override VarInt Type => 38;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 1.95, 0.6);

        public override Identifier Identifier => new("husk");
    }
}
