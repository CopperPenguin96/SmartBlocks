using GemBlocks.Blocks;
/*
* The MIT License (MIT)
* 
* Copyright (c) 2014-2015 Merten Peetz
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*/
/*
 * Modified License
* The MIT License (MIT)
* 
* Copyright (c) 2019 by apotter96
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*/
namespace GemBlocks.Worlds
{
    /// <summary>
    /// Can be used to define the default block layers of the part
    /// of the world that was created by GemBlocks. This results in
    /// a flat world where the blocks of each Y-coordinate are the
    /// same until they get overwritten. It is recommended to
    /// combine the DefaultLayers with the FlatGenerator to get a
    /// consitent world.
    /// </summary>
    public class DefaultLayers
    {
        private readonly Block[] _layers = new Block[World.MaxHeight];

        /// <summary>
        /// Sets the layer at the given Y-coordinate with the
        /// given material.
        /// </summary>gv
        public void SetLayer(int y, Block material)
        {
            // Validate layer
            if (!ValidLayer(y))
            {
                // Fail silently :'(
                return;
            }

            // Set layer
            _layers[y] = material;
        }

        /// <summary>
        /// Sets the layers of the given range of Y-coordinates
        /// (including y1 and y2) with the given material.
        /// </summary>
        /// <param name="y1">The lower Y-coordiante</param>
        /// <param name="y2">The higher Y-coordinate</param>
        /// <param name="material">The block</param>
        public void SetLayers(int y1, int y2, Block material)
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
                _layers[y] = material;
            }
        }

        /// <summary>
        /// Gets the material at the given Y-coordinate
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public Block GetLayer(int y)
        {
            // Validate layer
            return !ValidLayer(y) ? null : _layers[y];
        }

        /// <summary>
        /// Checks whether the Y-coordinate is valid.
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool ValidLayer(int y)
        {
            return y <= _layers.Length - 1 && y >= 0;
        }
    }
}
