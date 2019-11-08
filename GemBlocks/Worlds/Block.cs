using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GemBlocks.Worlds
{
    public class Block
    {
        [JsonProperty("type")]
        public int Type;

        [JsonProperty("meta")]
        public int Meta;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("text_type")]
        public string TextType;

        public Block(int type, int meta)
        {
            Type = type;
            Meta = meta;
        }
    }
}
