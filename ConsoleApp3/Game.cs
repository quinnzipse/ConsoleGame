using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Game
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
        public void goToShop()
        {
            Console.WriteLine("Welcome to the shop!\nYou currently have $" + Program.hero.Money + "!\n\nWhat would you like to buy?");
            // for(int i=0; )
        }
        public void goToHeal()
        { }
        public void goToRest()
        { }
    }
}
