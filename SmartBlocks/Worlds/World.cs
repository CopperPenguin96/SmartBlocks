using System.Drawing;
using MinecraftTypes;
using SmartBlocks.Blocks;
using SmartBlocks.Generators;
using SmartBlocks.Worlds.Raids;
using SmartNbt;
using SmartNbt.Tags;

namespace SmartBlocks.Worlds
{
    public class World : IBlockContainer
    {
        /// <summary>
        /// Max world height
        /// </summary>
        public const int MaxHeight = 256;

        /// <summary>
        /// The default transparency level
        /// </summary>
        public const byte DefaultTransparency = 1;

        /// <summary>
        /// The default sky light level (max light)
        /// </summary>
        public const byte DefaultSkyLight = 0xF;

        private readonly Dictionary<Point, Region> _regions = new();
        private readonly Level _level;
        
        /// <summary>
        /// The generator to be used to create the world.
        /// </summary>
        public IGenerator Generator { get; }

        public List<InterestPoint> InterestPoints { get; set; }

        public RaidList RaidList { get; set; }

        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="level">The level that is used to define the world settings</param>
        public World(Level level)
        {
            _level = level;
            Generator = _level.Generator;
        }

        public World(string saveDir)
        {
            saveDir = "Worlds/" + saveDir;
            if (saveDir == null)
                throw new ArgumentNullException(
                    "World location cannot be null. To create a new world use new World(new Level)");

            if (!Directory.Exists(saveDir))
                throw new FileNotFoundException(nameof(saveDir));

            string levelFile = saveDir + "level.dat";
            string levelOldFile = saveDir + "level.dat_old";
            Console.WriteLine(levelFile);
            if (!File.Exists(levelFile) && !File.Exists(levelOldFile))
            {
                throw new WorldLoadException("Invalid World: level.dat and level.dat_old missing.");
            }
            else if (!File.Exists(levelFile))
            {
                File.Copy(levelOldFile, levelFile);
            }

            Level level = new();
            NbtFile lvlFile = new NbtFile(levelFile);
            NbtCompound dataTag = (NbtCompound) lvlFile.RootTag.Tags.ElementAt(0);
            if (dataTag.Name != "Data")
            {
                throw new WorldLoadException("Invalid level.dat. Missing \"Data\" tag. Is \"");
            }

            foreach (NbtTag tag in dataTag.Tags)
            {
                Console.WriteLine("Tag: " + tag.Name);
            }
        }

        /// <summary>
        /// Sets a block at the given world position.
        /// </summary>
        /// <param name="pos">The XYZ Coord. Y must be between 0 and 255</param>
        /// <param name="block">The block</param>
        public void SetBlock(Position pos, Block? block)
        {
            // Check for valid height
            if (pos.Y is > MaxHeight - 1 or < 0)
            {
                // Fail silently
                return;
            }

            // Get region
            Region region = GetRegion((int)pos.X, (int)pos.Z, true);

            // Set block
            int blockX = GetRegionCoord((int)pos.X);
            int blockZ = GetRegionCoord((int)pos.Z);
            region.SetBlock(new Position(blockX, pos.Y, blockZ), block);
        }

        /// <summary>
        /// Sets a block at the given world position.
        /// </summary>
        /// <param name="x">The X-Coordinate</param>
        /// <param name="y">The Y-Coordinate (0-255)</param>
        /// <param name="z">The Z-Coordinate</param>
        /// <param name="block">The block</param>
        public void SetBlock(int x, int y, int z, Block? block)
        {
            SetBlock(new Position(x, y, z), block);
        }

        public Region GetRegion(int x, int z, bool create)
        {
            // Get region point
            int regionX = x / Region.BlocksPerRegionSize;
            if (x < 0) regionX--;

            int regionZ = z / Region.BlocksPerRegionSize;
            if (z < 0) regionZ--;

            Point point = new(regionX, regionZ);

            // Create region

            Region region;
            if (!_regions.ContainsKey(point) && create)
            {
                region = new Region(this, regionX, regionZ);
                _regions.Add(point, region);
                return region;
            }
            else if (_regions.ContainsKey(point))
            {
                region = _regions[point];
            }
            else
            {
                return GetRegion(x, z, true);
            }
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
            Region region = GetRegion((int)pos.X, (int)pos.Z, false);

            // Get light
            if (region == null) return DefaultSkyLight;
            int blockX = GetRegionCoord((int)pos.X);
            int blockZ = GetRegionCoord((int)pos.Z);
            return region.GetSkyLight(new Position(blockX, pos.Y, blockZ));
        }

        public byte GetSkyLightFromParent(IBlockContainer blockChild, Position child)
        {
            int x = Region.BlocksPerRegionSize * ((Region)blockChild).X + (int)child.X;
            int z = Region.BlocksPerRegionSize * ((Region)blockChild).Z + (int)child.Z;
            return GetSkyLight(new Position(x, child.Y, z));
        }

        public void SpreadSkyLight(byte light)
        {
            try
            {
                foreach (Region region in _regions.Values)
                {
                    region.SpreadSkyLight(light);
                }
            }
            catch (InvalidOperationException)
            {
                // _regions was modified, need to redo loop.
                SpreadSkyLight(light);
            }
        }

        public void Save()
        {
            // Creates worlds directory
            string worldDir = "Worlds/";
            if (!Directory.Exists(worldDir))
            {
                Directory.CreateDirectory(worldDir);
            }

            // Get level directory
            string levelName = _level.Name;
            string lvlDir = worldDir + levelName;
            if (Directory.Exists(lvlDir))
            {
                int dirPostFix = 0;
                do
                {
                    dirPostFix++;
                    lvlDir = worldDir + levelName + dirPostFix;
                } while (Directory.Exists(lvlDir));
            }

            // Create directories
            Directory.CreateDirectory(lvlDir);
            if (lvlDir[^1] != '/') lvlDir += '/';
            string regionDir = lvlDir + "region/";
            Directory.CreateDirectory(regionDir);

            // Write session.lock
            string sessionLockFile = lvlDir + "session.lock";
            var sessionLockWriter = File.CreateText(sessionLockFile);
            sessionLockWriter.Write(DateTime.Now.Ticks);
            sessionLockWriter.Flush();
            sessionLockWriter.Close();

            // Write level.dat
            string lvlFile = lvlDir + "level.dat";
            if (Directory.Exists(lvlFile))
            {
                if (File.Exists(lvlDir + "level.dat_old"))
                {
                    File.Delete(lvlDir + "level.dat_old");
                }

                File.Copy(lvlFile, lvlDir + "level.dat_old");
            }

            File.Delete(lvlFile);
            NbtFile nbtFile = new(new NbtCompound("") {_level.Nbt});
            nbtFile.SaveToFile(lvlFile, NbtCompression.GZip);
            
            Console.WriteLine("test");
            // Calculate height maps
            foreach (Region region in _regions.Values)
            {
                region.CalculateHeightMap();
            }

            Console.WriteLine("test2");
            // Set sky light
            AddSkyLight();

            // Spread sky light
            for (int i = DefaultSkyLight; i > 1; i--)
            {
                SpreadSkyLight((byte)i);
            }

            // Iterate regions
            for (int index = 0; index <= _regions.Count - 1; index++)
            {
                Point point = _regions.Keys.ToList()[index];
                Region region = _regions.Values.ToList()[index];

                // Save region
                string regionFile = regionDir +
                                    "r." + point.X + "." + point.Y + ".mca";
                region.WriteToFile(regionFile);
            }

            // Save raids
            string dataDir = lvlDir + "data/";
            if (!Directory.Exists(dataDir))
                Directory.CreateDirectory(dataDir);

            NbtFile raids = new NbtFile(new NbtCompound("") {RaidList.Tag});
            string raidFile = dataDir + "raids.dat";
            if (File.Exists(raidFile)) File.Delete(raidFile);
            raids.SaveToFile(raidFile, NbtCompression.GZip);
            
            // Save datapacks
            string dataPacksDir = lvlDir + "datapacks/";
            if (!Directory.Exists(dataPacksDir))
                Directory.CreateDirectory(dataPacksDir);

            // Save POIs
            string poiDir = lvlDir + "poi/";
            if (!Directory.Exists(poiDir))
                Directory.CreateDirectory(poiDir);

            List<NbtCompound> sections = new();
            List<Point> points = new();
            for (int x = 0; x < _regions.Count; x++)
            {
                Region region = _regions.Values.ToList()[x];

                NbtList records = new("Records", NbtTagType.Compound);
                foreach (var poi in 
                         from poi 
                             in InterestPoints 
                         from chunk 
                             in region.Chunks 
                         where chunk.HasBlocks
                             && chunk.X == poi.Position.X
                             && chunk.Z == poi.Position.Z 
                         select poi)
                {
                    records.Add(poi.Tag);
                    points.Add(new(poi.Position.X, poi.Position.Z));
                }

                NbtCompound number = new("4")
                {
                    new NbtBoolean("Valid", true),
                    records
                };

                sections.Add(number);
            }

            NbtCompound data = new("Data");
            foreach (NbtCompound section in sections)
            {
                data.Add(section);
            }

            NbtCompound root = new()
            {
                data,
                new NbtInt("DataVersion", InterestPoint.DataVersion)
            };

            foreach (Point point in points)
            {
                RegionFile poiFile = new(poiDir + "r." + point.X + "." + point.Y + ".mca");
                NbtOutputStream output = new(
                    poiFile.GetChunkDataWriterStream(point.X, point.Y).BaseStream, false);

                try
                {
                    output.WriteTag(root);
                }
                finally
                {
                    output.Close();
                }
            }
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
