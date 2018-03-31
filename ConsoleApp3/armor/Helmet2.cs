using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame.armor
{
    class Helmet2 : Armor
    {
        public Helmet2() : base("Helmet (Lvl 2)")
        {
            Durability = 1000;
            Cost = 75;
            Strength = 2;
        }
    }
}