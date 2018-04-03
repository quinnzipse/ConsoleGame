using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.weapons
{
    class Sniper : Weapon
    {
        public Sniper() : base("Sniper")
        {
            Durability = 1000;
            Damage = 25;
            Range = 3;
            Cost = 100;
        }
    }
}
