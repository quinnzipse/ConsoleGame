using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.lib;

namespace ConsoleGame
{
    public class Hero : Character
    {
        public Hero(string name) : base(name, CharacterType.HERO, 100.0, 20000)
        {

        }
    }

}
