using SmartBlocks.Blocks;

namespace SmartBlocks.Generators;

public class DefaultLayers
{
    public readonly Block?[] Layers = new Block?[258];

    /// <summary>
    /// Sets the layer at the given Y-coordinate with the
    /// given material.
    /// </summary>gv
    public void SetLayer(int y, Block? material)
    {
        // Validate layer
        if (!ValidLayer(y))
        {
            // Fail silently :'(
            return;
        }

        // Set layer
        Layers[y] = material;
    }

    /// <summary>
    /// Sets the layers of the given range of Y-coordinates
    /// (including y1 and y2) with the given material.
    /// </summary>
    /// <param name="y1">The lower Y-coordiante</param>
    /// <param name="y2">The higher Y-coordinate</param>
    /// <param name="material">The block</param>
    public void SetLayers(int y1, int y2, Block? material)
    {
        // Validate layers
        if (!ValidLayer(y1) || !ValidLayer(y2))
        {
            // Fail silently D':
            return;
        }

        // Set layers
        for (int y = y1; y <= y2; y++)
        {
            Layers[y] = material;
        }
    }

    /// <summary>
    /// Gets the material at the given Y-coordinate
    /// </summary>
    /// <param name="y"></param>
    /// <returns></returns>
    public Block? GetLayer(int y)
    {
        // Validate layer
        return !ValidLayer(y) ? null : Layers[y];
    }

    /// <summary>
    /// Checks whether the Y-coordinate is valid.
    /// </summary>
    /// <param name="y"></param>
    /// <returns></returns>
    public bool ValidLayer(int y)
    {
        return y <= Layers.Length - 1 && y >= 0;
    }
}