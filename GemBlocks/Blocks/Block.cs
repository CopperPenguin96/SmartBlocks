using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemBlocks.Blocks
{
    public class Block
    {
        /// <summary>
        /// The basic ID without additional data
        /// </summary>
        public byte Type { get; }

        /// <summary>
        /// Holds additional information, specifically what kind it is
        /// </summary>
        public byte Meta { get; }

        /// <summary>
        /// The official name of the block i.e. "Stone" or "Cobblestone"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The official identifier of the block i.e. minecraft:{TextType}
        /// </summary>
        public string TextType { get; set; }

        /// <summary>
        /// 0 = fully opaque;
        /// 1 = full transparent;
        /// > 1 = transparent but the light level is decreased by n at this block
        /// </summary>
        public int Transparency { get; set; }

        public Block(int type, int meta)
        {
            Type = (byte) type;
            Meta = (byte) meta;
        }
    }
}
