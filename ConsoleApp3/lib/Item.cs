using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.armor;
using ConsoleGame.healing;
using ConsoleGame.weapons;

namespace ConsoleGame.lib
{
    public class Item
    {
        public static Armor[] armors = new Armor[] { new Helmet1(), new Helmet2(), new ChestPlate1(), new ChestPlate2(), new Leggings1(), new Leggings2() };
        public static HealthItem[] healthItems = new HealthItem[] { new Potion(), new Bandage(), new FirstAid(), new MedKit() };
        public static Weapon[] weapons = new Weapon[] { new Knife(), new Crossbow(), new Rifle(), new Shotgun(), new Sniper() };

        protected Item(string name)
        {
            this.Name = name;
            this.ItemCount = 1;
        }

        public String Name { get; set; }
        public int ItemCount { get; set; }
    }
}
