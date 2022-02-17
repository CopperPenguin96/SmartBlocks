using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Villagers
{
    public class WanderingTrader : AbstractVillager
    {
        public override string Name => "Wandering Trader";

        public override VarInt Type => 100;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 1.95, 0.6);

        public override Identifier Identifier => new("wandering_trader");
    }
}
