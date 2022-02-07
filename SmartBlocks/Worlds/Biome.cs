using MinecraftTypes;

namespace SmartBlocks.Worlds
{
    public sealed class Biome
    {
        public string Name { get; set; }

        public Identifier Id { get; set; }

        public Biome(string name, Identifier id)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        private static readonly Dictionary<int, Biome> _biomes = new()
        {
            { 0, new("The Void", "the_void") },
            { 1, new("Plains", "plains") },
            { 2, new("Sunflower Plains", "sunflower_plains") },
            { 3, new("Snowy Plains", "snowy_plains") },
            { 4, new("Ice Spikes", "ice_spikes") },
            { 5, new("Desert", "desert") },
            { 6, new("Swamp", "swamp") },
            { 7, new("Forest", "forest") },
            { 8, new("FlowerForest", "flower_forest") },
            { 9, new("Birch Forest", "birch_forest") },
            { 10, new("Dark Forest", "dark_forest") },
            { 11, new("Old Growth Birch Forest", "old_growth_birch_forest") },
            { 12, new("Old Growth Pine Taiga", "old_growth_pine_taiga") },
            { 13, new("Old Growth Spruce Taiga", "old_growth_spruce_taiga") },
            { 14, new("Taiga", "taiga") },
            { 15, new("Snowy Taiga", "snowy_taiga") },
            { 16, new("Savanna", "savanna") },
            { 17, new("Savanna Plateau", "savanna_plateau") },
            { 18, new("Windswept Hills", "windswept_hills") },
            { 19, new("Windswept Gravelly Hills", "windswept_gravelly_hills") },
            { 20, new("Windswept Forest", "windswept_forest") },
            { 21, new("Windswept Savanna", "windswept_savanna") },
            { 22, new("Jungle", "jungle") },
            { 23, new("Sparse Jungle", "sparce_jungle") },
            { 24, new("Bamboo Jungle", "bamboo_jungle") },
            { 25, new("Badlands", "badlands") },
            { 26, new("Eroded Badlands", "eroded_badlands") },
            { 27, new("Wooded Badlands", "wooded_badlands") },
            { 28, new("Meadow", "meadow") },
            { 29, new("Grove", "grove") },
            { 30, new("Snowy Sloves", "snowy_slopes") },
            { 31, new("Frozen Peaks", "frozen_peaks") },
            { 32, new("Jagged Peaks", "jagged_peaks") },
            { 33, new("Stony Peaks", "stony_peaks") },
            { 34, new("River", "river") },
            { 35, new("Frozen River", "frozen_river") },
            { 36, new("Beach", "beach") },
            { 37, new("Snowy Beach", "snowy_beach") },
            { 38, new("Stony Shore", "stony_shore") },
            { 39, new("Warm Ocean", "warm_ocean") },
            { 40, new("Lukewarm", "lukewarm") },
            { 41, new("Deep Lukewarm Ocean", "deep_lukewarm_ocean") },
            { 42, new("Ocean", "ocean") },
            { 43, new("Deep Ocean", "deep_ocean") },
            { 44, new("Cold Ocean", "cold_ocean") },
            { 45, new("Deep Cold Ocean", "deep_cold_ocean") },
            { 46, new("Frozen Ocean", "frozen_ocean") },
            { 47, new("Deep Frozen Ocean", "deep_frozen_ocean") },
            { 48, new("Mushroom Fields", "mushroom_fields") },
            { 49, new("Dripstone Caves", "dripstone_caves") },
            { 50, new("Lush Caves", "lush_caves") },
            { 51, new("Nether Wastes", "nether_wastes") },
            { 52, new("Warped Forest", "warped_foreset") },
            { 53, new("Crimson Forest", "crimson_forest") },
            { 54, new("Soul Sand Valley", "soul_sand_valley") },
            { 55, new("Basalt Deltas", "basalt_deltas") },
            { 56, new("The End", "the_end") }, // 0.0
            { 57, new("End Highlands", "end_highlands") },
            { 58, new("End Midlands", "end_midlands") },
            { 59, new("Small End Islands", "small_end_islands") },
            { 60, new("End Barrens", "end_barrens") }
        };

        public static implicit operator Biome(Identifier id)
        {
            for (int x = 0; x < _biomes.Count; x++)
            {
                Biome biome = _biomes[x];
                if (biome.Id.ToString() != id.ToString()) continue;

                return biome;
            }

            return null!;
        }

        public static implicit operator Biome(int id)
        {
            return _biomes[id];
        }
    }
}
