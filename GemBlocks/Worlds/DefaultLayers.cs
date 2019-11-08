using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GemBlocks.Worlds
{
    public class DefaultLayers
    { 
        private Block[] _layers = new Block[World.MaxHeight];

        public void SetLayer(int y, Block material)
        {
            // Validate layer
            if (!ValidLayer(y)) return;

            // Set layer
            _layers[y] = material;
        }

        public void SetLayers(int y1, int y2, Block material)
        {
            // Validate layer
            if (!ValidLayer(y1) || !ValidLayer(y2)) return;

            for (int y = y1; y <= y2; y++)
            {
                _layers[y] = material;
            }
        }

        public Block GetLayer(int y)
        {
            return !ValidLayer(y) ? null : _layers[y];
        }

        private bool ValidLayer(int y)
        {
            return y <= _layers.Length - 1 && y >= 0;
        }
    }
}
