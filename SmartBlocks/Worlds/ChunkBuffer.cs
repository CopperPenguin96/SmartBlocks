namespace SmartBlocks.Worlds
{
    public class ChunkBuffer : MemoryStream
    {
        private readonly int _x, _z;
        private readonly RegionFile _parent;

        public ChunkBuffer(int x, int z, RegionFile parent)
        {
            _x = x;
            _z = z;
            _parent = parent;
        }

        public void Close()
        {
            _parent.Write(_x, _z, base.GetBuffer(), (int) Length);
        }
    }
}
