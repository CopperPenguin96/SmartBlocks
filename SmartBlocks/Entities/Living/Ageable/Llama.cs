﻿using MinecraftTypes;

namespace SmartBlocks.Entities.Living.Ageable
{
    public class Llama : ChestedHorse
    {
        public override string Name => "Llama";

        public override VarInt Type => 46;

        internal override bool UseSpawnEntityOnly => false;

        internal override bool UseSpawnPaintingOnly => false;

        internal override bool UseSpawnXpOnly => false;

        internal override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox => new(0.9, 1.87, 0.9);

        public override Identifier Identifier => new("llama");

        /// <summary>
        /// Number of columns of 3 slots in the llama's inventory
        /// once a chest is equipped
        /// </summary>
        public VarInt Strength { get; set; } = 0;

        /// <summary>
        /// A dye color, or -1 if no carpet equipped
        /// </summary>
        public VarInt CarpetColor { get; set; } = -1;

        public LlamaVariant Variant { get; set; } = 0;
    }

    public enum LlamaVariant
    {
        Creamy = 0,
        White = 1, 
        Brown = 2, 
        Gray = 3
    }
}
