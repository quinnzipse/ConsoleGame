using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame.armor
{
    class DefaultArmor : Armor
    {
        public DefaultArmor() : base("\nArmor:")
        {
            Durability = 0;
            Cost = 0;
            Strength = 0;
        }
    }
}