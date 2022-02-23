using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class TraderLlama : Llama
    {
        public override string Name => "Trader Llama";

        public override VarInt Type => 94;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.9, 1.87, 0.9);

        public override Identifier Identifier => new("trader_llama");
    }
}
