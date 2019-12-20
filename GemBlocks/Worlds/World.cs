using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using GemBlocks.Blocks;
using GemBlocks.Levels;
using java.io;
using org.jnbt;
using static GemBlocks.Utils.JavaSystem;
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

        public void SetBlock(Position pos, Block block)
        {
            // Check for valid height
            if (pos.Y > MaxHeight - 1 || pos.Y < 0)
            {
                // Fail silently
                return;
            }

            // Get region
            Region region = GetRegion((int) pos.X, (int) pos.Z, true);

            // Set block
            int blockX = GetRegionCoord((int) pos.X);
            int blockZ = GetRegionCoord((int) pos.Z);
            region.SetBlock(new Position(blockX, pos.Y, blockZ), block);
        }

        public Region GetRegion(int x, int z, bool create)
        {
            // Get region point
            int regionX = x / Region.BlocksPerRegionSize;
            if (x < 0) regionX--;

            int regionZ = z / Region.BlocksPerRegionSize;
            if (z < 0) regionZ--;

            Point point = new Point(regionX, regionZ);

            // Create region
            Region region = _regions[point];
            if (region != null || !create) return region;
            region = new Region(this, regionX, regionZ, _layers);
            _regions.Add(point, region);

            return region;
        }

        private static int GetRegionCoord(int coord)
        {
            int regionCoord = coord % Region.BlocksPerRegionSize;
            if (regionCoord < 0)
            {
                regionCoord += Region.BlocksPerRegionSize;
            }

            return regionCoord;
        }

        public byte GetSkyLight(Position pos)
        {
            // Get region
            Region region = GetRegion((int) pos.X, (int) pos.Z, false);

            // Get light
            if (region == null) return DefaultSkyLight;
            int blockX = GetRegionCoord((int) pos.X);
            int blockZ = GetRegionCoord((int) pos.Z);
            return region.GetSkyLight(new Position(blockX, pos.Y, blockZ));
        }

        public byte GetSkyLightFromParent(IBlockContainer blockChild, Position child)
        {
            int x = Region.BlocksPerRegionSize * ((Region) blockChild).X + (int) child.X;
            int z = Region.BlocksPerRegionSize * ((Region) blockChild).Z + (int) child.Z;
            return GetSkyLight(new Position(x, child.Y, z));
        }

        public void SpreadSkyLight(byte light)
        {
            foreach (Region region in _regions.Values)
            {
                region.SpreadSkyLight(light);
            }
        }

        public File Save()
        {
            // Creates worlds directory
            File worldDir = new File("worlds");
            if (!DirExists(worldDir))
            {
                worldDir.mkdir();
            }

            // Get level directory
            string levelName = _level.Name;
            File levelDir = new File(worldDir, levelName);
            if (DirExists(levelDir))
            {
                int dirPostFix = 0;
                do
                {
                    dirPostFix++;
                    levelDir = new File(worldDir, levelName + dirPostFix);
                } while (DirExists(levelDir));
            }

            // Create directories
            levelDir.mkdir();

            File regionDir = new File(levelDir, "region");
            regionDir.mkdir();

            // Write session.lock
            File sessionLockFile = new File(levelDir, "session.lock");
            DataOutputStream dos = new DataOutputStream(new FileOutputStream(sessionLockFile));
            try
            {
                dos.writeLong(CurrentTimeMillis());
            }
            finally
            {
                dos.close();
            }

            // Write level.dat
            File levelFile = new File(levelDir, "level.dat");
            FileOutputStream fos = new FileOutputStream(levelFile);
            NBTOutputStream nbtOut = new NBTOutputStream(fos, true);
            try
            {
                nbtOut.writeTag(_level.Tag);
            }
            finally
            {
                nbtOut.close();
            }

            // Calculate height maps
            foreach (Region region in _regions.Values)
            {
                region.CalculateHeightMap();
            }

            // Set sky light
            AddSkyLight();

            // Spread sky light
            for (int i = DefaultSkyLight; i > 1; i--)
            {
                SpreadSkyLight((byte) i);
            }

            // Iterate regions
            for (int index = 0; index <= _regions.Count - 1; index++)
            {
                Point point = _regions.Keys.ToList()[index];
                Region region = _regions.Values.ToList()[index];

                // Save region
                File regionFile = new File(regionDir,
                    "r." + point.X + "." + point.Y + ".mca");
                region.WriteToFile(regionFile);
            }

            return levelDir;
        }

        private void AddSkyLight()
        {
            foreach (Region region in _regions.Values)
            {
                region.AddSkyLight();
            }
        }

        private static bool DirExists(File f)
        {
            return (f.exists() && f.isDirectory());
        }
    }
}
