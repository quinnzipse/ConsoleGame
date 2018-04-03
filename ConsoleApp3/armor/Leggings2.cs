using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame.armor
{
    class Leggings2 : Armor
    {
        public Leggings2() : base("Leggings (Lvl 2)")
        {
            Durability = 1000;
            Cost = 100;
            Strength = 2;
        }
    }
}