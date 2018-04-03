using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.healing
{
    class DefaultHeal : HealthItem
    {
        public DefaultHeal() : base("\nHealth Items:")
        {
            HealPoints = 0;
            Cost = 0;
        }
    }
}
