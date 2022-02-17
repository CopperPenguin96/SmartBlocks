using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Pig : Animal
    {
        public override string Name => "Pig";

        public override VarInt Type => 64;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.9, 0.9, 0.9);

        public override Identifier Identifier => new("pig");

        public bool HasSaddle { get; set; } = false;

        /// <summary>
        /// Total time to boost with a carrot on a stick for
        /// </summary>
        public VarInt TimeToBoost { get; set; } = 0;
    }
}
