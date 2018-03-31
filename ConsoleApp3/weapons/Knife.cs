using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.weapons
{
    class Knife : Weapon
    {
        public Knife() : base("Knife")
        {
            Durability = 100;
            Damage = 5;
            Range = 0;
            Cost = 20;
        }
    }
}
