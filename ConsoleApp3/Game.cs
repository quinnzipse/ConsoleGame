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
            Console.Beep();
            Console.Title = Program.GAME_NAME + " - Shop";
            Armor[] armors = new Armor[] { new Helmet1(), new Helmet2(), new ChestPlate1(), new ChestPlate2(), new Leggings1(), new Leggings2() };
            HealthItem[] healthItems = new HealthItem[] { new Potion(), new Bandage(), new FirstAid(), new MedKit() };
            Weapon[] weapons = new Weapon[] { new Knife(), new Crossbow(), new Rifle(), new Shotgun(), new Sniper() };

            Item[][] shopItems = new Item[][] { armors, healthItems, weapons };

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
            int[] finder = find();
            Console.WriteLine("Would you like to buy this item? " + shopItems[finder[0]][finder[1]].Name);
            Console.ReadLine();
            string confirm = Console.ReadLine();
            if (confirm.ToLower() == "y" || confirm.ToLower() == "yes")
            {
                Console.Beep();
                purchase(shopItems[finder[0]][finder[1]]);
            }
            else goToShop();

            Console.Beep();

            goToTown(currentTown);
            return;
        }
        public void purchase(Item item)
        {
            Weapon w = new Weapon();
            Armor a = new Armor();
            HealthItem h = new HealthItem();
            int cost = 0;
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
                cost = h.Cost;
            }

            if(Program.hero.Money > cost)
            {
                Program.hero.Money = Program.hero.Money - cost;
                switch (type)
                {
                    case 'w':
                        Program.hero.Weapons.Add(w);
                        break;
                    case 'a':
                        Program.hero.Armor.Add(a);
                        break;
                    case 'h':
                        Program.hero.HealthItems.Add(h);
                        break;
                }
                Console.Beep();
                Console.WriteLine("ADDED!");
            }

        }
        public int[] find()
        {
            int[] finder = new int[2];

            for (int i = 0; i < 1; i++)
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
