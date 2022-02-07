using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBlocks.Worlds
{
    public class WorldLoadException : Exception
    {
        public WorldLoadException() : base()
        {

        }

        public WorldLoadException(string message) : base(message)
        {

        }

        public WorldLoadException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
