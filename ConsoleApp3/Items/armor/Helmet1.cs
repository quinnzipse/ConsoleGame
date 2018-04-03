using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame.armor
{
    class Helmet1 : Armor
    {
        public Helmet1() : base("Helmet (Lvl 1)")
        {
            Durability = 100;
            Cost = 30;
            Strength = 1;
        }
    }
}