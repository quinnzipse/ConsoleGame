using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame.armor
{
    class ChestPlate1 : Armor
    {
        public ChestPlate1() : base("Chest Plate (Lvl 1)")
        {
            Durability = 100;
            Cost = 60;
            Strength = 1;
        }
    }
}