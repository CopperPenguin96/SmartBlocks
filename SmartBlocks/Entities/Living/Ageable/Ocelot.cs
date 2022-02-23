using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Ocelot : Animal
    {
        public override string Name => "Ocelot";

        public override VarInt Type => 59;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.6, 0.7, 0.6);

        public override Identifier Identifier => new("ocelot");

        public bool IsTrusting { get; set; } = false;
    }
}
