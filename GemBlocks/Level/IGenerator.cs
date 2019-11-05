using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemBlocks.Level
{
    public interface IGenerator
    {
        /// <summary>
        /// Returns the generator name as it is used in the level file
        /// </summary>
        GeneratorName GeneratorName { get; }

        /// <summary>
        /// Returns the generator options as they are used in the level file
        /// </summary>
        string GeneratorOptions { get; }
    }
}
