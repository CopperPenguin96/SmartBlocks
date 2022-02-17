using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class TraderLlama : Llama
    {
        public override string Name => "Trader Llama";

        public override VarInt Type => 94;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.9, 1.87, 0.9);

        public override Identifier Identifier => new("trader_llama");
    }
}
