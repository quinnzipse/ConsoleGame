using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.forests;

namespace ConsoleGame.lib
{
    class Forest
    {

        private static Type[] forestTypes = new Type[] { typeof(RedWoodForest), typeof(MazeForest) };
        private static Random random = new Random();

        protected Forest(string name) {
            this.name = name;
            this.paths = new ForestPath[] { };
        }

        public static void displayAndExecutePaths(ForestPath[] paths)
        {
            Console.WriteLine("You left are in front of a sign with a bunch of different paths.");
            Console.WriteLine("0) Leave the forest");
            for (int i = 0; i < paths.Length; i++)
            {
                var p = paths[i];
                var dispNum = i + 1;
                Console.WriteLine(dispNum + ") " + p.name);
            }
            Console.WriteLine();
            Console.Write("Which path will you take? ");
            var path = Console.ReadLine();
            int pathNum = 0;
            var parsed = int.TryParse(path, out pathNum);
            if(!parsed || pathNum < 0 || pathNum > paths.Length)
            {
                Console.Clear();
                Console.WriteLine("Invalid option. Try again.");
                Console.WriteLine();
                displayAndExecutePaths(paths);
                return;
            }
            switch(pathNum)
            {
                case 0:
                    Console.WriteLine("You have left the forest.");
                    return;
                default:
                    paths[pathNum-1].take();
                    break;
            }
        }

        public static Forest findForest()
        {
            if (forestTypes.Length == 0) return null;
            var forest = random.Next(0, forestTypes.Length);
            return (Forest)forestTypes[forest].GetConstructors()[0].Invoke(new object[] { });
        }

        public void execute()
        {
            Console.WriteLine("You walk into the " + this.name + " forest.");
            displayAndExecutePaths(this.paths);
        }

        public string name { get; set; }
        public ForestPath[] paths { get; set; }

        public class ForestPath
        {
            public ForestPath(string name) { this.name = name; }
            public string name { get; set; }
            public ForestPath[] subpaths = new ForestPath[] { };
            public delegate bool TakePath();
            public event TakePath takePath;

            public void take()
            {
                bool res = takePath.Invoke();
                if (!res)
                {
                    Console.WriteLine("You have left the forest.");
                    return;
                }
                if(this.subpaths.Length > 0)
                {
                    Console.Clear();
                    Forest.displayAndExecutePaths(subpaths);
                }
                Console.Clear();
                Console.WriteLine("You have reached the end of the forest and decided to leave.");
            }
        }
    }
}
