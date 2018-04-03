using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame
{
    public class Weapon : Item
    {
        public Weapon() : base("Nothing") { }

        public Weapon(string name) : base(name)
        {
        }
        public int Damage
        {
            get; set;
        }
        public int Durability
        {
            get; set;
        }
        public int Range
        {
            get; set;
        }
        public int Cost
        {
            get; set;
        }
    }
}
