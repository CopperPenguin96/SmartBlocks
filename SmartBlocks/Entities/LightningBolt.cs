using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class LightningBolt : Entity
    {
        public override string Name => "Lightning Bolt";

        public override VarInt Type => 45;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.0, 0.0, 0.0);

        public override Identifier Identifier => new("lightning_bolt");
    }
}
