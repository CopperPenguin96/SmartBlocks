using SmartNbt;
using SmartNbt.Tags;

namespace SmartBlocks.Entities.Living.Mobs.Memories
{
    public class Brain : ITagProvider
    {
        public List<Memory> Memories { get; set; }

        public void AddMemory(Memory memory)
        {
            Memories.Add(memory);
        }

        public NbtTag Tag
        {
            get
            {
                NbtCompound memories = new("memories");
                foreach (Memory mem in Memories)
                {
                    memories.Add(mem.Tag);
                }

                return new NbtCompound("Brain", memories);
            }
        }
    }
}
