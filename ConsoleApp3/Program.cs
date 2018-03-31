using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
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

                Hero Hero = new Hero();
                Hero.Name = Name;

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

    class Game
    {
        public bool Playing
        {
            get; set;
        }
        public void GameOver()
        {

        }
        public void Save() { }
        public void goToTown(string TownName)
        {
            Console.WriteLine("Welcome to " + TownName + ". What would you like to do? \n"
                               + "\t 1.) Shop\n"
                               + "\t 2.) Heal\n"
                               + "\t 3.) Rest\n"
                               + "\t 4.) Save");
            switch (Console.ReadLine())
            {
                case "1":
                    goToShop();
                    break;
                case "2":
                    goToHeal();
                    break;
                case "3":
                    goToRest();
                    break;
                case "4":
                    Save();
                    break;
                default:
                    break;
            }
        }
        private void goToShop()
        { }
        private void goToHeal()
        { }
        private void goToRest()
        { }
    }
    class Character
    {
        public string Name
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }
        public int Health
        {
            get; set;
        }
    }
    class Hero : Character
    {

    }
    class Enemy : Character
    {

    }
    class Item
    {
        public string Name
        {
            get; set;
        }
    }
    class Weapon : Item
    {
        public int Damage
        {
            get; set;
        }
        public int Durability
        {
            get; set;
        }
    }
}