using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.healing
{
    class FirstAid : HealthItem
    {
        public FirstAid() : base("First Aid Kit")
        {
            HealPoints = 20;
            Cost = 30;
        }
    }
}
