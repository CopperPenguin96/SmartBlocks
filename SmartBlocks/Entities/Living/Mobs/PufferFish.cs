using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Mobs
{
    public class PufferFish : AbstractFish
    {
        public override string Name => "Pufferfish";

        public override VarInt Type => 70;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.7, 0.7, 0.7);

        public override Identifier Identifier => new("pufferfish");

        /// <summary>
        /// Varies from 0 to 2
        /// </summary>
        public VarInt PuffState { get; set; } = 0;
    }
}
