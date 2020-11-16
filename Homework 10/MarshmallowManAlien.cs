using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_10 {
    class MarshmallowManAlien : Alien{

        //constructor
        public MarshmallowManAlien() {
            Health = 100;
            Name = "Marshmallow Man Alien";
            Damage = 1;
        }

        public int GetDamage() {
            return Damage; ;
        }

    }
}
