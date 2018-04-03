using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame.forests
{
    class MazeForest : Forest
    {
        public MazeForest() : base("Maze")
        {
            ForestPath path = new ForestPath("Follow");
            path.takePath += Path_takePath;
            paths = new ForestPath[] { path };
        }

        private bool Path_takePath()
        {
            Console.WriteLine("You have become lost in the middle of the forest and cannot find your way out.");
            while (true) { }
            return false;
        }
    }
}
