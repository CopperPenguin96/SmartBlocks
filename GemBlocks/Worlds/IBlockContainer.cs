using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
