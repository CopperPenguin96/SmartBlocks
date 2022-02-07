using SmartNbt.Tags;

namespace SmartBlocks.Generators
{
    public interface IGenerator
    {
        static string Name { get; }

        GenType Type { get; }

        string Options { get; }

        long Seed { get; set; }

        NbtCompound Nbt { get; }
    }
}
