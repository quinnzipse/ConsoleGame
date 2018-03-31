using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame.forests
{
    class RedWoodForest : Forest
    {
        public RedWoodForest() : base("Redwood")
        {
            ForestPath JQFalls = new ForestPath("JQ Falls");
            JQFalls.takePath += JQFalls_takePath;
            paths = new ForestPath[] { JQFalls };
        }

        private bool JQFalls_takePath()
        {
            Console.Clear();
            Console.WriteLine("A math master stops you while entering the path.");
            Console.WriteLine("In order to pass, you must answer a simple math equation.");
            Console.WriteLine();
            Console.WriteLine("The equation (24x^2+25x-47)/(ax-2) = (-8x-3)-(53/ax-2) is true for all variables of x ≠ (2/a) where a is a constant\n\nWhat is the value of a?\n\n");
            Console.Write("Answer: ");
            int ans = 0;
            if(!int.TryParse(Console.ReadLine(), out ans))
            {
                Console.Clear();
                Console.WriteLine("The math master has turned you away for your inability to use numbers.");
                return false;
            }
            Console.Clear();
            if (ans != -3)
            {
                Console.Clear();
                Console.WriteLine("The math master has turned you away for not answering the question correctly.");
                return false;
            }
            Console.WriteLine("You proceed on. Press any key to continue.");
            Console.ReadKey();
            return true;
        }
    }
}
