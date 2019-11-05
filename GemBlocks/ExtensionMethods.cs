using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemBlocks
{
    public static class BooleanUtil
    {
        /// <summary>
        /// Converts a boolean to a numerical representation
        /// </summary>
        /// <param name="bo">The boolean in question</param>
        /// <returns>0 if false, 1 if true</returns>
        public static byte ToByte(this bool bo)
        {
            return bo ? (byte)1 : (byte)0;
        }
    }
}
