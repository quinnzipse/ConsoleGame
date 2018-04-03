using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.weapons
{
    class DefaultWeapon : Weapon
    {
        public DefaultWeapon() : base("\nWeapons:")
        {
            Durability = 0;
            Damage = 0;
            Range = 0;
            Cost = 0;
        }
    }
}
