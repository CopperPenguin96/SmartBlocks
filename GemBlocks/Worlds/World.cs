using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using fNbt;
using GemBlocks.Blocks;
using GemBlocks.Levels;

namespace GemBlocks.Worlds
{
    public class World: IBlockContainer
    {
        public const int MaxHeight = 256;
        public const byte DefaultTransparency = 1;
        public const byte DefaultSkyLight = 0xF;

        private readonly Dictionary<Point, Region> _regions = new Dictionary<Point, Region>();
        private readonly Level _level;
        private readonly DefaultLayers _layers;


        public World(Level level)
        {
            _level = level;
        }

        public World(Level level, DefaultLayers layers)
        {
            _level = level;
            _layers = layers;
        }

        public void SetBlock(int x, int y, int z, Block block)
        {
            // Check for valid height
            if (y > MaxHeight - 1 || y < 0)
            {
                // Fail silently... this sounds depressing
                return;
            }

            Region region = GetRegion(x, z, true);

            // Set block
            int blockX = GetRegionCoord(x);
            int blockZ = GetRegionCoord(z);
            region.SetBlock(blockX, y, blockZ, block);
        }

        private Region GetRegion(int x, int z, bool create)
        {
            int regionX = x / Region.BlocksPerRegionSide;
            if (x < 0) regionX--;

            int regionZ = z / Region.BlocksPerRegionSide;
            if (z < 0) regionZ--;

            Point point = new Point(regionX, regionZ);

            Region region = _regions[point];
            if (region != null || !create) return region;
            region = new Region(this, regionX, regionZ, _layers);
            _regions.Add(point, region);

            return region;
        }

        private static int GetRegionCoord(int coord)
        {
            int regionCoord = coord % Region.BlocksPerRegionSide;
            if (regionCoord < 0)
            {
                regionCoord += Region.BlocksPerRegionSide;
            }

            return regionCoord;
        }

        public byte GetSkyLight(int x, int y, int z)
        {
            Region region = GetRegion(x, z, false);

            if (region == null) return DefaultSkyLight;
            int blockX = GetRegionCoord(x);
            int blockZ = GetRegionCoord(z);
            return region.GetSkyLight(blockX, y, blockZ);
        }

        public byte GetSkyLightFromParent(IBlockContainer child,
            int childX, int childY, int childZ)
        {
            int x = Region.BlocksPerRegionSide * ((Region) child).XPos + childX;
            int z = Region.BlocksPerRegionSide * ((Region) child).ZPos + childZ;
            return GetSkyLight(x, childY, z);
        }

        public void SpreadSkyLight(byte light)
        {
            foreach (Region region in _regions.Values)
            {
                region.SpreadSkyLight(light);
            }
        }

        private static byte[] BytesToLong(long value)
        {
            ulong bValue = (ulong) value;
            return new[]
            {
                (byte)((bValue & 0xFF00000000000000) >> 56),

                (byte)((bValue & 0xFF000000000000) >> 48),

                (byte)((bValue & 0xFF0000000000) >> 40),

                (byte)((bValue & 0xFF00000000) >> 32),

                (byte)((bValue & 0xFF000000) >> 24),

                (byte)((bValue & 0xFF0000) >> 16),

                (byte)((bValue & 0xFF00) >> 8),

                (byte)(bValue & 0xFF)
            };
        }

        public string Save(string worldsDir)
        {
            if (!Directory.Exists(worldsDir))
            {
                Directory.CreateDirectory(worldsDir);
            }

            string levelName = _level.LevelName + "/";
            string levelDir = "";
            if (Directory.Exists(worldsDir + levelName))
            {
                int dirPostFix = 0;
                do
                {
                    dirPostFix++;
                    levelDir = levelName + dirPostFix;
                } while (Directory.Exists(levelDir));
            }

            Directory.CreateDirectory(levelDir);
            string regionDir = levelDir + "/" + "region";
            Directory.CreateDirectory(regionDir);

            // write session.lock
            string sessionLockFile = levelDir + "/session.lock";
            Console.WriteLine("Writing file: " + sessionLockFile);
            FileStream dos = new FileStream(sessionLockFile, FileMode.CreateNew);
            try
            {
                byte[] bts = BytesToLong(DateTime.Now.Millisecond);
                dos.Write(bts, 0, bts.Length);
            }
            finally
            {
                dos.Close();
            }

            // Write level.dat
            string levelFile = levelDir + "/level.dat";
            Console.WriteLine("Writing file: " + levelFile);
            FileStream fos = new FileStream(levelFile, FileMode.CreateNew);
            NbtTag levelTag = _level.Tag;
            NbtWriter nbtOut = new NbtWriter(fos, levelTag.Name);
            try
            {
                nbtOut.WriteTag(_level.Tag);
            }
            catch (Exception )
            {
                nbtOut.BaseStream.Close();
            }

            // Calculate height maps
            Console.WriteLine("Calculate height maps");
            foreach (Region region in _regions.Values)
            {
                region.CalculateHeightMap();
            }

            // Set sky light
            Console.WriteLine("Adding sky light");
            AddSkyLight();

            // Spread sky light
            Console.WriteLine("Spreading sky light");
            for (int i = DefaultSkyLight; i > 1; i--)
            {
                SpreadSkyLight(1);
            }

            Console.WriteLine();

            // Iterate regions
            for (int item = 0; item <= _regions.Count; item++)
            {
                Point key = Point.Empty;

                int itemKey = 0;
                foreach (var k in _regions.Keys)
                {
                    if (itemKey == item)
                    {
                        key = k;
                    }

                    itemKey++;
                }

                _regions.TryGetValue(key, out Region region);

                // Save region
                string regionFile = regionDir + $"r.{key.X}.{key.Y}.mca";
                Console.WriteLine("Writing file: " + regionFile);
                region.WriteToFile(regionFile);
            }

            Console.WriteLine("Done");
            return levelDir;
        }

        private void AddSkyLight()
        {
            foreach (Region region in _regions.Values)
            {
                region.AddSkyLight();
            }
        }
    }
}
