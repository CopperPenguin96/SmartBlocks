using MinecraftTypes;

namespace SmartBlocks.Entities.Minecarts
{
    public class MinecartHopper : AbstractMinecartContainer
    {
        public override string Name => "Minecart Hopper";

        public override VarInt Type => 54;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.98, 0.7, 0.98);

        public override Identifier Identifier => new("furnace_minecart");
    }
}
