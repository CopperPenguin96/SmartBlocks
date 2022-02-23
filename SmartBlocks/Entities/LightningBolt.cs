using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class LightningBolt : Entity
    {
        public override string Name => "Lightning Bolt";

        public override VarInt Type => 45;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.0, 0.0, 0.0);

        public override Identifier Identifier => new("lightning_bolt");
    }
}
