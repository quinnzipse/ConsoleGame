using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;
using ConsoleGame.weapons;
using ConsoleGame.armor;
using ConsoleGame.healing;

namespace ConsoleGame
{
    class Program
    {
        public static Hero hero;
        public static int days = 0;

        public static String GAME_NAME = "RandomGame";

        static void Main(string[] args)
        {
            Console.Title = GAME_NAME;
            Game Game = new Game();
            Game.Playing = true;
            Console.WriteLine("Please enter the name of your new Hero: ");
            string Name = Console.ReadLine();

            Hero Hero = new Hero(Name);

            while (Game.Playing)
            {
                Console.WriteLine();
                Console.WriteLine("Your name is: " + Hero.Name);
                Console.WriteLine("It is day: " + days);

                hero = new Hero(Name);
                hero.Armor.Add(new DefaultArmor());
                hero.HealthItems.Add(new DefaultHeal());
                hero.Weapons.Add(new DefaultWeapon());

                Console.WriteLine("What would you like to do: \n"
                                  + "\t 1.) Go into town\n"
                                  + "\t 2.) Go into the forest\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Game.goToTown("Belmont");
                        break;
                    case "2":
                        Console.Clear();
                        Forest.findForest().execute();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        Game.Playing = false;
                        break;
                }
            }
        }
    }
}