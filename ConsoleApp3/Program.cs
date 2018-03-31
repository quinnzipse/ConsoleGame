using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game Game = new Game();
            Game.Playing = true;
            while (Game.Playing)
            {
                Console.WriteLine("Please enter the name of your new Hero: ");
                string Name = Console.ReadLine();

                Hero Hero = new Hero(Name);

                Console.WriteLine("Your name is: " + Hero.Name);
                Console.WriteLine("What would you like to do: \n"
                                  + "\t 1.) Go into town\n"
                                  + "\t 2.) Go into the forest\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Game.goToTown("Belmont");
                        break;
                    case "2":
                    default:
                        Console.WriteLine("Invalid Option");
                        Game.Playing = false;
                        break;
                }
            }
        }
    }
}