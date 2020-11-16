using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_10 {
    class OgreAlien : Alien{

        //constructor
        public OgreAlien() {
            Health = 100;
            Name = "Ogre Alien";
            Damage = 6;
        }

        public int GetDamage() {
            return Damage;
        }      

    }
}
