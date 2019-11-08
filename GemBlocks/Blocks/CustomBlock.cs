namespace GemBlocks.Blocks
{
    public class CustomBlock: Block
    {
        public CustomBlock(byte type, byte meta) : base(type, meta)
        {
        }

        public new byte Type { get; set; }
        public new byte Meta { get; set;  }
        public new string Name { get; set; }
        public new string TextType { get; set; }
        public new int Transparency { get; set; }
    }
}
