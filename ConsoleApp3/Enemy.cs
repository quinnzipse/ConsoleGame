using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame
{
    public class Enemy : Character
    {
        public Enemy(string name) : base(name, CharacterType.ENEMY, 100.0)
        {

        }
    }
}
