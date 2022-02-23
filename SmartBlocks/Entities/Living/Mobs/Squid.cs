using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Mobs
{
    public class Squid : WaterAnimal
    {
        public override string Name => "Squid";

        public override VarInt Type => 86;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.8, 0.8, 0.8);

        public override Identifier Identifier => new("squid");
    }
}
