using MinecraftTypes;

namespace SmartBlocks.Entities
{
    public class Painting : Entity
    {
        public override string Name => "Painting";

        public override VarInt Type => 60;

        public int PaintingType { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public override bool UseSpawnEntityOnly => false;

        public override bool UseSpawnPaintingOnly => true;

        public override bool UseSpawnXpOnly => false;

        public override bool AllowedSpawn => true;

        public override BoundingBox BoundingBox { get; set; }

        public override Identifier Identifier => new("painting");

        public Painting(PaintingKind kind)
        {
            switch (kind)
            {
                case PaintingKind.Kebab:
                    Register(0, 0, 0, 16, 16);
                    break;
                case PaintingKind.Aztec:
                    Register(1, 16, 0, 16, 16);
                    break;
                case PaintingKind.Alban:
                    Register(2, 32, 0, 16, 16);
                    break;
                case PaintingKind.Aztec2:
                    Register(3, 48, 0, 16, 16);
                    break;
                case PaintingKind.Bomb:
                    Register(4, 64, 0, 16, 16);
                    break;
                case PaintingKind.Plant:
                    Register(5, 80, 0, 16, 16);
                    break;
                case PaintingKind.Wasteland:
                    Register(6, 96, 0, 16, 16);
                    break;
                case PaintingKind.Pool:
                    Register(7, 0, 32, 32, 16);
                    break;
                case PaintingKind.Corbet:
                    Register(8, 32, 32, 32, 16);
                    break;
                case PaintingKind.Sea:
                    Register(9, 64, 32, 32, 16);
                    break;
                case PaintingKind.Sunset:
                    Register(10, 96, 32, 32, 16);
                    break;
                case PaintingKind.Creebet:
                    Register(11, 128, 32, 32, 16);
                    break;
                case PaintingKind.Wanderer:
                    Register(12, 0, 64, 16, 32);
                    break;
                case PaintingKind.Graham:
                    Register(13, 16, 64, 16, 32);
                    break;
                case PaintingKind.Match:
                    Register(14, 0, 128, 32, 32);
                    break;
                case PaintingKind.Bust:
                    Register(16, 32, 128, 32, 32);
                    break;
                case PaintingKind.Stage:
                    Register(16, 64, 128, 32, 32);
                    break;
                case PaintingKind.Void:
                    Register(17, 96, 128, 32, 32);
                    break;
                case PaintingKind.SkullRoses:
                    Register(18, 128, 128, 32, 32);
                    break;
                case PaintingKind.Wither:
                    Register(19, 160, 128, 32, 32);
                    break;
                case PaintingKind.Fighters:
                    Register(20, 0, 96, 64, 32);
                    break;
                case PaintingKind.Pointer:
                    Register(21, 0, 192, 64, 64);
                    break;
                case PaintingKind.Pigscene:
                    Register(22, 64, 192, 64, 64);
                    break;
                case PaintingKind.BurningSkull:
                    Register(23, 128, 192, 64, 64);
                    break;
                case PaintingKind.Skeleton:
                    Register(24, 192, 64, 64, 48);
                    break;
                case PaintingKind.DonkeyKong:
                    Register(25, 192, 112, 64, 48);
                    break;
            }
        }

        private void Register(int kind, int x, int y, int width, int height)
        {
            PaintingType = (int) kind;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }

    public enum PaintingKind : int
    {
        Kebab = 0,
        Aztec = 1,
        Alban = 2,
        Aztec2 = 3,
        Bomb = 4,
        Plant = 5,
        Wasteland = 6,
        Pool = 7,
        Corbet = 8,
        Sea = 9,
        Sunset = 10,
        Creebet = 11,
        Wanderer = 12,
        Graham = 13,
        Match = 14,
        Bust = 15,
        Stage = 16,
        Void = 17,
        SkullRoses = 18,
        Wither = 19,
        Fighters = 20,
        Pointer = 21,
        Pigscene = 22,
        BurningSkull = 23,
        Skeleton = 24,
        DonkeyKong = 25
    }
}