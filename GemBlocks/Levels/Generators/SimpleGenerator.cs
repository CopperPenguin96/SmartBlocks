using System;
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
namespace GemBlocks.Levels.Generators
{
    /// <inheritdoc />
    /// <summary>
    /// Generates the normal world types (Default, Amplified, Large Biomes)
    /// </summary>
    public class SimpleGenerator: IGenerator
    {
        /// <summary>
        /// The kind of world
        /// </summary>
        public WorldType WorldKind { get; set; }

        /// <summary>
        /// Used to enumerate through the enum as if it was a string
        /// </summary>
        /// <returns></returns>
        private string GetWorldKindString()
        {
            switch (WorldKind)
            {
                case WorldType.Default: return WorldKinds.Default;
                case WorldType.Amplified: return WorldKinds.Amplified;
                case WorldType.LargeBiomes: return WorldKinds.LargeBiomes;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Tells the world generator what kind of world
        /// </summary>
        public string Name => GetWorldKindString();

        /// <inheritdoc />
        /// <summary>
        /// Options....
        /// </summary>
        public string Options => null;

        /// <summary>
        /// Initializes this instance with the specified world kind
        /// </summary>
        /// <param name="value"></param>
        public SimpleGenerator(string value)
        {
            switch (value.ToLower())
            {
                case WorldKinds.Default:
                    WorldKind = WorldType.Default;
                    break;
                case WorldKinds.Amplified:
                    WorldKind = WorldType.Amplified;
                    break;
                case WorldKinds.LargeBiomes:
                    WorldKind = WorldType.LargeBiomes;
                    break;
                default:
                    throw new ArgumentException(nameof(value));
            }
        }
    }
}
