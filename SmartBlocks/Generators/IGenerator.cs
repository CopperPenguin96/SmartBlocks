using SmartBlocks.Worlds;

namespace SmartBlocks.Generators;

public interface IGenerator : ITagProvider
{
    GenType Type { get; }

    Dimension Dimension { get; }

    long Seed { get; set; }
}