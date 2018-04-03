using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame.armor
{
    class ChestPlate2 : Armor
    {
        public ChestPlate2() : base("Chest Plate (Lvl 2)")
        {
            Durability = 1000;
            Cost = 150;
            Strength = 2;
        }
    }
}