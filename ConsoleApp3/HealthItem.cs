using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame
{
    public class HealthItem : Item
    {
        public HealthItem() : base("Nothing") { }

        public HealthItem(string name) : base(name)
        {
        }
        public int HealPoints
        {
            get; set;
        }
        public int Cost
        {
            get; set;
        }
    }
}
