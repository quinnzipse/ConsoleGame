using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.weapons
{
    class Rifle : Weapon
    {
        public Rifle() : base("Rifle")
        {
            Durability = 1000;
            Damage = 25;
            Cost = 100;
            Range = 2;
        }
    }
}
