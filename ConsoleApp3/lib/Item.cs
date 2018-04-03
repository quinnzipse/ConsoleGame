using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.lib
{
    public class Item
    {
        protected Item(string name)
        {
            this.Name = name;
            
        }

        public String Name { get; set; }
    }
}
