using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.healing
{
    class Potion : HealthItem
    {
        public Potion() : base("Bandage")
        {
            HealPoints = 0;
            Cost = 5;
        }
    }
}
