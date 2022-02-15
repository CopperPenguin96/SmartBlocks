using MinecraftTypes;
using SmartBlocks.Blocks;
using SmartBlocks.Generators;
using SmartNbt;

namespace SmartBlocks.Worlds
{
    public class Region : IBlockContainer
    {
        public const int ChunksPerRegionSide = 32;
        public const int BlocksPerRegionSize = ChunksPerRegionSide * Chunk.BlocksPerChunkSide;

        internal readonly RectArray<Chunk> Chunks = new(ChunksPerRegionSide, ChunksPerRegionSide);

        private readonly IBlockContainer _parent;

        public IGenerator Generator => _parent.Generator;

        public Region(IBlockContainer parent, int xPos, int zPos)
        {
            _parent = parent;
            X = xPos;
            Z = zPos;
        }

        public int X { get; }
        public int Z { get; }

        public void SetBlock(Position pos, Block? block)
        {
            // Get chunk
            Chunk chunk = GetChunk((int)pos.X, (int)pos.Z, true);

            // Set block
            int blockX = (int)pos.X % Chunk.BlocksPerChunkSide;
            int blockZ = (int)pos.Z % Chunk.BlocksPerChunkSide;
            chunk.SetBlock(new Position(blockX, pos.Y, blockZ), block);
        }

        public byte GetSkyLight(Position pos)
        {
            // Get chunk
            Chunk chunk = GetChunk((int)pos.X, (int)pos.Z, false);

            if (chunk != null)
            {
                int blockX = (int)pos.X % Chunk.BlocksPerChunkSide;
                int blockZ = (int)pos.Z % Chunk.BlocksPerChunkSide;
                byte light = chunk.GetSkyLight(new Position(blockX, pos.Y, blockZ));
                return light;
            }

            return World.DefaultSkyLight;
        }

        public byte GetSkyLightFromParent(IBlockContainer blockChild,
            Position child)
        {
            int x = ((Chunk)blockChild).X * Chunk.BlocksPerChunkSide + (int)child.X;
            int z = ((Chunk)blockChild).Z * Chunk.BlocksPerChunkSide + (int)child.Z;

            // Same region?
            if (x is >= 0 and < BlocksPerRegionSize && z is >= 0 and < BlocksPerRegionSize)
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
                    Chunk chunk = Chunks.Get(x, z);
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
                    Chunk chunk = Chunks.Get(x, z);
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
            Chunk chunk = Chunks.Get(chunkX, chunkZ);

            // Create chunk
            if (chunk != null || !create) return chunk;
            chunk = new Chunk(this, chunkX, chunkZ);
            Chunks.Set(chunkX, chunkZ, chunk);

            return chunk;
        }

        public void CalculateHeightMap()
        {
            for (int x = 0; x < ChunksPerRegionSide; x++)
            {
                for (int z = 0; z < ChunksPerRegionSide; z++)
                {
                    Chunk chunk = Chunks.Get(x, z);
                    chunk?.CalculateHeightMap();
                }
            }
        }

        public void WriteToFile(string path)
        {
            // Write region file
            RegionFile regionFile = new(path);
            try
            {
                for (int x = 0; x < ChunksPerRegionSide; x++)
                {
                    for (int z = 0; z < ChunksPerRegionSide; z++)
                    {
                        Chunk chunk = Chunks.Get(x, z);
                        if (chunk is not {HasBlocks: true}) continue;

                        NbtOutputStream output = new(
                            regionFile.GetChunkDataWriterStream(x, z).BaseStream, false
                        );

                        try
                        {
                            output.WriteTag(Chunks.Get(x, z).Tag);
                        }
                        finally
                        {
                            output.Close();
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
