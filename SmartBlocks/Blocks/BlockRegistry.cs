using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftTypes;
using Newtonsoft.Json;

namespace SmartBlocks.Blocks
{
    public class BlockRegistry
    {
        public static Dictionary<Identifier, Block> Blocks = new();

        public static bool Initialized;

        public static void Init()
        {
            string json = Encoding.UTF8.GetString(Properties.Resources.blocks);
            List<Block> blocks = JsonConvert.DeserializeObject<List<Block>>(json)!;

            foreach (Block b in blocks)
            {
                Blocks.Add(b.ItemId, b);
            }

            Initialized = true;
        }
    }
}
