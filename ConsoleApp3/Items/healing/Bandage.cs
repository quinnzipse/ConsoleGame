using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.healing
{
    class Bandage : HealthItem
    {
        public Bandage() : base("Bandage")
        {
            HealPoints = 5;
            Cost = 10;
        }
    }
}
