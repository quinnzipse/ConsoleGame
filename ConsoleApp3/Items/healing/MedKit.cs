using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.healing
{
    class MedKit : HealthItem
    {
        public MedKit() : base("MedKit")
        {
            HealPoints = 75;
            Cost = 100;
        }
    }
}
