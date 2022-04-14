using SmartNbt.Tags;

namespace SmartBlocks.Worlds;

public interface ITagProvider
{
    NbtTag Tag { get; }
}