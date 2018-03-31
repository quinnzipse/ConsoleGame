using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.weapons
{
    class Shotgun : Weapon
    {
        public Shotgun() : base("Shotgun")
        {
            Durability = 1000;
            Damage = 25;
            Range = 1;
            Cost = 100;
        }
    }
}
