using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.armor;
using ConsoleGame.healing;
using ConsoleGame.weapons;
using ConsoleGame.lib;

namespace ConsoleGame
{
    public class Game
    {
        public String currentTown;
        public bool Playing
        {
            get; set;
        }
        public void GameOver()
        {
            Console.WriteLine("GAME OVER (Tell us if you ever get this)");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.BackgroundColor = 000;
            Console.ReadLine();
        }
        public void Save() {
            Console.WriteLine("SOON");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.ReadLine();
            Console.Beep();
            goToTown(currentTown);
        }
        public void goToTown(string TownName)
        {
            currentTown = TownName;
            Console.Title = Program.GAME_NAME + " - " + TownName;
            Console.Clear();
            Console.Beep();
            Console.WriteLine("Welcome to " + TownName + ". What would you like to do? \n"
                               + "\t 1.) Shop\n"
                               + "\t 2.) Heal\n"
                               + "\t 3.) Rest\n"
                               + "\t 4.) Save\n"
                               + "\t 5.) What do I have");
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
                case "5":
                    heroStats();
                    break;
                case "6":
                    //Does nothing currently
                    break;
                default:
                    Console.Beep();
                    Console.WriteLine("\nInvalid Option");
                    Console.Beep();
                    Console.ReadLine();
                    Console.Beep();
                    goToTown(currentTown);
                    break;
            }
        }

        //SHOP FUNCTIONS
        public void goToShop()
        {
            //Frontend Shop
            Console.Beep();
            Console.Title = Program.GAME_NAME + " - Shop";
            Item[][] shopItems = new Item[][] { Item.armors, Item.healthItems, Item.weapons };
            Console.Clear();
            Console.WriteLine("Welcome to the shop!\nYou currently have $" + Program.hero.Money + "!\n\nHere is a list of our products.");
            for (int x = 0; x < shopItems.Length; x++)
                {
                    String arrayName = shopItems[x].ToString().Split('.')[1];
                    Console.WriteLine("\n" + arrayName.Substring(0, arrayName.Length - 2));

                    if (shopItems[x].GetType().Equals(typeof(Weapon[])))
                    {
                        for (int i = 0; i < shopItems[x].Length; i++)
                        {
                            Weapon weapon = (Weapon)shopItems[x][i];
                            Console.WriteLine(x + "" + i + ". " + weapon.Name + " -- Cost: " + weapon.Cost);
                        }
                    }
                    else if (shopItems[x].GetType().Equals(typeof(HealthItem[])))
                    {
                        for (int i = 0; i < shopItems[x].Length; i++)
                        {
                            HealthItem healthItem = (HealthItem)shopItems[x][i];
                            Console.WriteLine(x + "" + i + ". " + healthItem.Name + " -- Cost: " + healthItem.Cost);
                        }
                    }
                    else if (shopItems[x].GetType().Equals(typeof(Armor[])))
                    {
                        for (int i = 0; i < shopItems[x].Length; i++)
                        {
                            Armor armor = (Armor)shopItems[x][i];
                            Console.WriteLine(x + "" + i + ". " + armor.Name + " -- Cost: " + armor.Cost);
                        }
                    }
                    else
                    {
                        Console.WriteLine("OOF");
                    }
                }
            Console.Beep();
            Console.Write("\nWhat would you like to purchase? ");

            //Backend Shop
            int[] finder = findItem();
            if (finder[0] > 2 || finder[0] < 1) return;
            Console.WriteLine("Would you like to buy this item? " + shopItems[finder[0]][finder[1]].Name);
            Console.ReadLine();
            string confirm = Console.ReadLine();
            if (confirm.ToLower() == "y" || confirm.ToLower() == "yes")
                {
                    Console.Beep();
                    Purchase(shopItems[finder[0]][finder[1]]);
                }
            else goToShop();
            Console.Beep();
            goToTown(currentTown);
            return;
        }
        private void Purchase(Item item)
        {
            Weapon w = new Weapon();
            Armor a = new Armor();
            HealthItem h = new HealthItem();
            int cost = int.MaxValue;
            int amount = 0;
            char type = 'o';

            if (item.GetType().BaseType.Equals(typeof(Weapon)))
            {
                type = 'w';
                w = (Weapon)item;
                cost = w.Cost;
            }
            else if (item.GetType().BaseType.Equals(typeof(Armor)))
            {
                type = 'a';
                a = (Armor)item;
                cost = a.Cost;
            }
            else if (item.GetType().BaseType.Equals(typeof(HealthItem)))
            {
                type = 'h';
                h = (HealthItem)item;
                Console.WriteLine("How many would you like to purchase? ");
                amount = int.Parse(Console.ReadLine());
                if (amount > 0) cost = h.Cost * amount;
                else Console.WriteLine("Invalid Amount");
            }

            if(Program.hero.Money >= cost)
            {
                Program.hero.Money -= cost;
                switch (type)
                {
                    case 'w':
                        if (!Program.hero.Weapons.Contains(w)) Program.hero.Weapons.Add(w);
                        else
                        {
                            Program.hero.Money += cost;
                            Console.WriteLine("You Already Own This Item!");
                        }
                        break;
                    case 'a':
                        if(!Program.hero.Armor.Contains(a)) Program.hero.Armor.Add(a);
                        else
                        {
                            Program.hero.Money += cost;
                            Console.WriteLine("You Already Own This Item!");
                        }
                        break;
                    case 'h':
                        for (int i = 0; i < amount; i++)
                        {
                            Program.hero.HealthItems.Add(h);
                        }
                        break;
                }
                Console.Beep();
                Console.WriteLine("ADDED!");
            }
            else
            {
                Console.WriteLine("\nInsignificant Funds! Please choose another option.");
                Console.ReadLine();
                goToShop();
            }

        }
        private int[] findItem()
        {
            int[] finder = new int[2];

            for (int i = 0; i < finder.Length; i++)
            {
                int something = Console.Read() - 48;
                if (something >= 0)
                {
                    finder[i] = something;
                }
                else
                {
                    Console.Read();
                    goToTown(currentTown);
                }
            }
            Console.Beep();
            return finder;
        }

        public void goToHeal()
        {
            Console.Beep();
            Console.Clear();
            String message = "Healing";
            for (int i = 0; i < 4; i++)
            {
                Console.Write(message);
                Console.ReadLine();
                Console.Beep();
                message = message + ".";
                Console.Clear();
            }
            Program.hero.currentHealth = 100;
            Console.WriteLine("All healed, thanks for stopping by!");
            Console.ReadLine();

            goToTown(currentTown);
        }

        public void goToRest()
        {
            Console.WriteLine("SOON");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.ReadLine();
            Console.Beep();
            goToTown(currentTown);
        }

        public void heroStats()
        {
            Console.Clear();
            Console.Beep();
            Console.WriteLine("CHARACTER STATS:\n");
            Console.WriteLine("Health: " + (Program.hero.Health * 100) + "%");
            Console.WriteLine("Money: $" + Program.hero.Money);
            Program.hero.Armor.ForEach((x) =>
            {
                Console.WriteLine(x.Name);
            });
            Program.hero.HealthItems.ForEach((x) =>
            {
                Console.WriteLine(x.Name);
            });
            Program.hero.Weapons.ForEach((x) =>
            {
                Console.WriteLine(x.Name);
            });
            Console.WriteLine("\nPress any button to continue...");
            Console.ReadLine();
            Console.Beep();
            goToTown(currentTown);
        }
    }
}
