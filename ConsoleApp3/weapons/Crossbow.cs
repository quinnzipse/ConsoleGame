using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.weapons
{
    class Crossbow : Weapon
    {
        public Crossbow() : base("Crossbow")
        {
            Durability = 1000;
            Damage = 10;
            Range = 2;
            Cost = 35;
        }
    }
}
