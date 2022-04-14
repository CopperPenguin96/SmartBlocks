using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBlocks.Entities.Living
{
    public enum ArmorType : byte
    {
        Leather = 0x00,
        Gold = 0x01,
        Chain = 0x02,
        Iron = 0x03,
        Diamond = 0x04,
        Netherite = 0x05,
        TurtleShell = 0x06 // Helmets only
    }

    public enum ArmorPart : byte
    {
        Boots = 0x00,
        Legs = 0x01,
        Chest = 0x02,
        Helmet = 0x03
    }
}
