using System.Collections.Generic;
using GemBlocks.Blocks;
using GemBlocks.Levels.Generators;
using GemBlocks.Utils;
using GemBlocks.Worlds;
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
namespace GemBlocks.Levels
{
    public class FlatGenerator: IGenerator
    {
        private readonly DefaultLayers _layers;

        public FlatGenerator()
        {
        }

        public FlatGenerator(DefaultLayers layers)
        {
            _layers = layers;
        }

        public string Name => "flat";

        public string Options
        {
            get
            {
                // Are there layers?
                if (_layers == null) return null;

                // Create generator options string
                int lastBlockId = 0;
                int count = 0;
                List<string> parts = new List<string>();
                for (int y = 0; y < World.MaxHeight; y++)
                {
                    bool isLast = y == World.MaxHeight;

                    // Get block id
                    int blockId = 0;
                    if (!isLast)
                    {
                        Block material = _layers.GetLayer(y);
                        if (material != null)
                        {
                            blockId = (int) material.Type;
                        }
                    }

                    if (y == 0 && !isLast)
                    {
                        lastBlockId = blockId;
                    }
                    else
                    {
                        // Further passes
                        if (blockId != lastBlockId || isLast)
                        {
                            // Dif. block, add to string
                            string part = "";
                            if (count != 1)
                            {
                                part += count + "*";
                            }

                            part += lastBlockId;

                            // Dont' add the last part if it's air
                            if (!isLast || lastBlockId != 0)
                            {
                                parts.Add(part);
                            }

                            lastBlockId = blockId;
                            count = 0;
                        }
                    }

                    count++;
                }

                // Create options string
                string layerOptions = StringUtils.Join(parts.ToArray(), ",");
                string options = "3;" + layerOptions;
                return options;
            }
        }

    }
}
