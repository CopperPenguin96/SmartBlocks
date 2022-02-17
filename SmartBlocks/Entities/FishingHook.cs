using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class FishingHook : Entity
    {
        public override string Name => "Fishing Hook";

        public override VarInt Type => 112;

        internal override bool UseSpawnEntityOnly => true;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.25, 0.25, 0.25);

        public override Identifier Identifier => new("fishing_hook");

        /// <summary>
        /// Hooked entity ID + 1, or 0 if there is no hooked entity
        /// </summary>
        public VarInt HookedId { get; set; } = 0;

        public bool IsCatchable { get; set; } = false;
    }
}
