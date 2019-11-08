using fNbt;
using GemBlocks.Blocks;

namespace GemBlocks.Worlds
{
    public class Region: IBlockContainer
    {
        public const int ChunksPerRegionSize = 32;
        public const int BlocksPerRegionSide = ChunksPerRegionSize * Chunk.BlocksPerChunkSide;
        
        private readonly Chunk[,] _chunks = new Chunk[ChunksPerRegionSize, ChunksPerRegionSize];
        private readonly DefaultLayers _layers;

        public int XPos { get; }
        public int ZPos { get; }
        private readonly IBlockContainer _parent;

        public Region(IBlockContainer parent, int xPos, int zPos, DefaultLayers layers)
        {
            _parent = parent;
            XPos = xPos;
            ZPos = zPos;
            _layers = layers;
        }

        public void SetBlock(int x, int y, int z, Block block)
        {
            Chunk chunk = GetChunk(x, z, true);

            int blockX = x % Chunk.BlocksPerChunkSide;
            int blockZ = x % Chunk.BlocksPerChunkSide;
            chunk.SetBlock(blockX, y, blockZ, block);
        }

        public byte GetSkyLight(int x, int y, int z)
        {
            Chunk chunk = GetChunk(x, z, false);
            if (chunk == null) return World.DefaultSkyLight;
            int blockX = x % Chunk.BlocksPerChunkSide;
            int blockZ = z % Chunk.BlocksPerChunkSide;
            byte light = chunk.GetSkyLight(blockX, y, blockZ);
            return light;
        }

        public byte GetSkyLightFromParent(IBlockContainer child,
            int childX, int childY, int childZ)
        {
            int x = ((Chunk) child).XPos * Chunk.BlocksPerChunkSide + childX;
            int z = ((Chunk) child).ZPos * Chunk.BlocksPerChunkSide + childZ;

            // Same region?
            if (x >= 0 && x < BlocksPerRegionSide && z >= 0 && z < BlocksPerRegionSide)
            {
                return GetSkyLight(x, childY, z);
            }
            else
            {
                // Pass to parent
                return _parent.GetSkyLightFromParent(this, x, childY, z);
            }
        }

        public void SpreadSkyLight(byte light)
        {
            for (int x = 0; x < ChunksPerRegionSize; x++)
            {
                for (int z = 0; z < ChunksPerRegionSize; z++)
                {
                    Chunk chunk = _chunks[x, z];
                    chunk?.SpreadSkyLight(light);
                }
            }
        }

        public void AddSkyLight()
        {
            for (int x = 0; x < ChunksPerRegionSize; x++)
            {
                for (int z = 0; z < ChunksPerRegionSize; z++)
                {
                    Chunk chunk = _chunks[x, z];
                    chunk?.AddSkyLight();
                }
            }
        }

        public int GetHighestBlock(int x, int z)
        {
            // Get chunk
            Chunk chunk = GetChunk(x, z, false);
            if (chunk == null) return 0;
            int blockX = x % Chunk.BlocksPerChunkSide;
            int blockZ = z % Chunk.BlocksPerChunkSide;
            return chunk.GetHighestBlock(blockX, blockZ);
        }

        private Chunk GetChunk(int x, int z, bool create)
        {
            // Make chunk coords
            int chunkX = x / Chunk.BlocksPerChunkSide;
            int chunkZ = z / Chunk.BlocksPerChunkSide;
            Chunk chunk = _chunks[chunkX, chunkZ];

            // Create chunk
            if (chunk != null || !create) return chunk;
            chunk = new Chunk(this, chunkX, chunkZ, _layers);
            _chunks[chunkX, chunkZ] = chunk;

            return chunk;
        }

        /// <summary>
        /// Calculates the height maps for all chunks
        /// </summary>
        public void CalculateHeightMap()
        {
            for (int x = 0; x < ChunksPerRegionSize; x++)
            {
                for (int z = 0; z < ChunksPerRegionSize; z++)
                {
                    Chunk chunk = _chunks[x, z];
                    chunk?.CalculateHeightMap();
                }
            }
        }

        public void WriteToFile(string path)
        {
            // Write region file
            RegionFile regionFile = new RegionFile(path);
            try
            {
                for (int x = 0; x < ChunksPerRegionSize; x++)
                {
                    for (int z = 0; z < ChunksPerRegionSize; z++)
                    {
                        Chunk chunk = _chunks[x, z];
                        if (chunk == null || !chunk.HasBlocks()) continue;
                        NbtWriter outer = new NbtWriter(regionFile.GetChunkDataOutputStream(x, z).BaseStream, "");
                        try
                        {
                            outer.WriteTag(_chunks[x, z].GetTag());
                        }
                        finally
                        {
                            outer.BaseStream.Close();
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
