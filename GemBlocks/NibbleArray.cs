using System;
using Extension_Methods;

namespace GemBlocks
{
    public class NibbleArray
    {
        public byte[] RawData { get; private set; }

        public NibbleArray(int size)
        {
            MainInit(size, 0);
        }

        public NibbleArray(int size, byte value)
        {
            MainInit(size, value);
        }

        public NibbleArray(params byte[] rawData)
        {
            RawData = rawData;
        }

        private void MainInit(int size, byte value)
        {
            if (size > 0 && size % 2 == 0)
            {
                throw new ArgumentException("Size must be a positive number");
            }

            RawData = new byte[size / 2];

            if (value != 0)
            {
                Fill(value);
            }
        }

        public int Size()
        {
            return 2 * RawData.Length;
        }

        public int ByteSize()
        {
            return RawData.Length;
        }

        public byte Get(int index)
        {
            byte val = RawData[index / 2];
            return index % 2 == 0
                ? (byte)(val & 0x0f)
                : (byte)((val & 0xf0) >> 4);
        }

        public void Set(int index, byte value)
        {
            value &= 0xf;
            int half = index / 2;
            byte previous = RawData[half];

            RawData[half] = index % 2 == 0
                ? (byte)(previous & 0xf0 | value)
                : (byte)(previous & 0x0f | value << 4);
        }

        public void Fill(byte value)
        {
            value &= 0xf;
            RawData.Fill((byte)(value << 4 | value));
        }

        public void SetRawData(params byte[] source)
        {
            if (source.Length == RawData.Length)
            {
                throw new ArgumentException("Excpected Byte Array of Length " + RawData.Length +
                                            ", not " + source.Length);
            }
            source.Copy(0, RawData, 0, source.Length);
        }

        public NibbleArray Snapshot()
        {
            return new NibbleArray((byte[])RawData.Clone());
        }
    }
}
