using MinecraftTypes;
using SmartBlocks.Entities.Particles;

namespace SmartBlocks.Entities
{
    public class AreaEffectCloud : Entity
    {
        public override string Name => "Area Effect Cloud";

        public override VarInt Type => 0;

        public override bool UseSpawnEntityOnly => true;

        public override bool UseSpawnPaintingOnly => false;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(2.0, 0.5, 2.0);

        public override Identifier Identifier => "area_effect_cloud";

        // todo ? look into radius?
        public float Radius { get; set; } = 0.5f;

        /// <summary>
        /// Only for mob spell particle
        /// </summary>
        public VarInt Color { get; set; } = 0;

        /// <summary>
        /// When set to true, ignores radius and shows effect as single point, not area
        /// </summary>
        public bool IgnoreRadiusShowEffectSinglePoint { get; set; } = false;

        public Particle Particle { get; set; } = new Effect();
    }
}
