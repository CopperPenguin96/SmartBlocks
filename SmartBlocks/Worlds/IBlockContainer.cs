using MinecraftTypes;
using SmartBlocks.Generators;

namespace SmartBlocks.Worlds;

public interface IBlockContainer
{
    /// <summary>
    /// Returns the sky light level of the block at given positon.
    /// If there is no block World.DefaultSkyLight will be returned.
    /// </summary>
    /// <param name="pos">The local XYZ-coordinate</param>
    /// <returns>The sky light level</returns>
    byte GetSkyLight(Position pos);

    /// <summary>
    /// Returns the sky light level of a block that is out of bounds
    /// of the child block container.
    /// </summary>
    /// <param name="childBlock">The child block container</param>
    /// <param name="child">The local X,Y, & Z coordinate</param>
    /// <returns>The sky light level</returns>
    byte GetSkyLightFromParent(
        IBlockContainer childBlock, Position child
    );

    /// <summary>
    /// Spreads the sky light.
    /// For each block that has the given light level it's
    /// adjacent blocks will be lit if their current light
    /// level is lower.
    /// </summary>
    /// <param name="light">The light level</param>
    void SpreadSkyLight(byte light);

    IGenerator Generator { get; }
}