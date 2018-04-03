using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.lib
{
    public class Character
    {
        protected Character(string name, CharacterType type, double health, int money)
        {
            this.Name = name;
            this.Type = type;
            this.currentHealth = health;
            this.Money = money;
        }
        public string Name
        {
            get; set;
        }
        protected double maxHealth = 100.0;
        public double currentHealth = 0;
        public CharacterType Type
        {
            get; set;
        }
        public double Health
        {
            get
            {
                return currentHealth / maxHealth;
            }
        }
        public int Money
        {
            get; set;
        }
        public List<Weapon> weapons
        {
            get; set;
        }

        public enum CharacterType
        {
            HERO,
            ENEMY
        }
    }
}
