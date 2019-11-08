using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemBlocks.Worlds
{
    public interface IBlockContainer
    {
        byte GetSkyLight(int x, int y, int z);

        byte GetSkyLightFromParent(IBlockContainer child,
            int childX, int childY, int childZ);

        void SpreadSkyLight(byte light);
    }
}
