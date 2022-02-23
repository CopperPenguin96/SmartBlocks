using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Monsters
{
    public class Phantom : Flying
    {
        public override string Name => "Phantom";

        public override VarInt Type => 63;

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.9, 0.5, 0.9);

        public override Identifier Identifier => new("phantom");

        public VarInt Size { get; set; } = 0;
    }
}
