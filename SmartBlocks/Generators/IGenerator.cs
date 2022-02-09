using SmartBlocks.Worlds;
using SmartNbt.Tags;

namespace SmartBlocks.Generators
{
    public interface IGenerator : ITagProvider
    {
        static string Name { get; }

        GenType Type { get; }

        string Options { get; }

        long Seed { get; set; }
    }
}
