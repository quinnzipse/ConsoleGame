using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame
{
    public class Armor : Item
    {
        public Armor(string name) : base(name)
        {
        }
        public int DamageRecieved
        {
            get; set;
        }
        public int Durability
        {
            get; set;
        }
        public int Cost
        {
            get; set;
        }
        public int Strength
        {
            get; set;
        }
    }
}
