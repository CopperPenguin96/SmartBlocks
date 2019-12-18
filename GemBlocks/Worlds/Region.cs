using System;
using System.Collections.Generic;
using System.Text;
using GemBlocks.Blocks;
using GemBlocks.Utils;
using java.io;
using org.jnbt;
using Console = System.Console;
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
    public class Region: IBlockContainer
    {
        public const int ChunksPerRegionSide = 32;
        public const int BlocksPerRegionSize = ChunksPerRegionSide * Chunk.BlocksPerChunkSide;

        private readonly RectArray<Chunk> _chunks = new RectArray<Chunk>(ChunksPerRegionSide, ChunksPerRegionSide);
        private readonly DefaultLayers _layers;

        private readonly IBlockContainer _parent;

        public Region(IBlockContainer parent, int xPos, int zPos, DefaultLayers layers)
        {
            _parent = parent;
            X = xPos;
            Z = zPos;
            _layers = layers;
        }

        public int X { get; }
        public int Z { get; }

        public void SetBlock(Position pos, Block block)
        {
            // Get chunk
            Chunk chunk = GetChunk(pos.X, pos.Z, true);

            // Set block
            int blockX = pos.X % Chunk.BlocksPerChunkSide;
            int blockZ = pos.Z % Chunk.BlocksPerChunkSide;
            chunk.SetBlock(new Position(blockX, pos.Y, blockZ), block);
        }

        public byte GetSkyLight(Position pos)
        {
            // Get chunk
            Chunk chunk = GetChunk(pos.X, pos.Z, false);

            if (chunk != null)
            {
                int blockX = pos.X % Chunk.BlocksPerChunkSide;
                int blockZ = pos.Z % Chunk.BlocksPerChunkSide;
                byte light = chunk.GetSkyLight(new Position(blockX, pos.Y, blockZ));
                return light;
            }

            return World.DefaultSkyLight;
        }

        public byte GetSkyLightFromParent(IBlockContainer blockChild,
            Position child)
        {
            int x = ((Chunk) blockChild).X * Chunk.BlocksPerChunkSide + child.X;
            int z = ((Chunk) blockChild).Z * Chunk.BlocksPerChunkSide + child.Z;

            // Same region?
            if (x >= 0 && x < BlocksPerRegionSize &&
                z >= 0 && z < BlocksPerRegionSize)
            {
                return GetSkyLight(new Position(x, child.Y, z));
            }
            else
            {
                // Pass to parent
                return _parent.GetSkyLightFromParent(this, new Position(x, child.Y, z));
            }
        }

        public void SpreadSkyLight(byte light)
        {
            for (int x = 0; x < ChunksPerRegionSide; x++)
            {
                for (int z = 0; z < ChunksPerRegionSide; z++)
                {
                    Chunk chunk = _chunks.Get(x, z);
                    chunk?.SpreadSkyLight(light);
                }
            }
        }

        public void AddSkyLight()
        {
            for (int x = 0; x < ChunksPerRegionSide; x++)
            {
                for (int z = 0; z < ChunksPerRegionSide; z++)
                {
                    Chunk chunk = _chunks.Get(x, z);
                    chunk?.AddSkyLight();
                }
            }
        }

        public int GetHighestBlock(int x, int z)
        {
            // Get chunk
            Chunk chunk = GetChunk(x, z, false);
            if (chunk != null)
            {
                int blockX = x % Chunk.BlocksPerChunkSide;
                int blockZ = z % Chunk.BlocksPerChunkSide;
                return chunk.GetHighestBlock(blockX, blockZ);
            }

            return 0;
        }

        private Chunk GetChunk(int x, int z, bool create)
        {
            // Make chunk coords
            int chunkX = x / Chunk.BlocksPerChunkSide;
            int chunkZ = z / Chunk.BlocksPerChunkSide;
            Chunk chunk = _chunks.Get(chunkX, chunkZ);

            // Create chunk
            if (chunk != null || !create) return chunk;
            chunk = new Chunk(this, chunkX, chunkZ, _layers);
            _chunks.Set(chunkX, chunkZ, chunk);

            return chunk;
        }

        public void CalculateHeightMap()
        {
            for (int x = 0; x < ChunksPerRegionSide; x++)
            {
                for (int z = 0; z < ChunksPerRegionSide; z++)
                {
                    Chunk chunk = _chunks.Get(x, z);
                    chunk?.CalculateHeightMap();
                }
            }
        }

        public void WriteToFile(File path)
        {
            // Write region file
            RegionFile regionFile = new RegionFile(path);
            try
            {
                for (int x = 0; x < ChunksPerRegionSide; x++)
                {
                    for (int z = 0; z < ChunksPerRegionSide; z++)
                    {
                        Chunk chunk = _chunks.Get(x, z);
                        if (chunk == null || !chunk.HasBlocks) continue;
                        NBTOutputStream outt = new NBTOutputStream(regionFile.GetChunkDataOutputStream(x, z), false);
                        try
                        {
                            outt.writeTag(_chunks.Get(x, z).Tag);
                        }
                        finally
                        {
                            outt.close();
                        }
                    }
                }
            }
            finally
            {
                regionFile.Close();
            }
        }
    }
}
