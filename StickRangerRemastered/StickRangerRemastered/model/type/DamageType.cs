using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickRangerRemastered.model.type
{

    [Flags]
    enum DamageType
    {

        physical = 0x01,
        thunder  = 0x02,
        fire     = 0x04,
        poison   = 0x08,
        ice      = 0x16,
        freeze   = 0x32,
    }
}
