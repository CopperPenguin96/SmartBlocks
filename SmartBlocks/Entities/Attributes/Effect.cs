using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBlocks.Entities.Attributes
{
    public enum Effect : byte
    {
        MoveSpeed = 0x00,
        MoveSlowdown = 0x01,
        DigSpeed = 0x02,
        DigSlowdown = 0x03,
        DamageBoost = 0x04,
        Weakness = 0x05,
        HealthBoost = 0x06,
        Luck = 0x07,
        Unluck = 0x08
    }
}
