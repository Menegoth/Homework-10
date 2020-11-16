using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_10 {
    class SnakeAlien : Alien {

        //constructor
        public SnakeAlien() {
            Health = 100;
            Name = "Snake Alien";
            Damage = 10;
        }


        public int GetDamage() {
            return Damage;
        }

    }
}
