using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame.armor
{
    class Leggings1 : Armor
    {
        public Leggings1() : base("Leggings (Lvl 1)")
        {
            Durability = 100;
            Cost = 40;
            Strength = 1;
        }
    }
}
