using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_10 {
    class Alien {

        //instance variables
        public int Health { get; set; } //0 = dead, 100 = full
        public string Name { get; set; }
        public int Damage { get; set; }

        //constructors
        public Alien() { }
        public Alien(int health, string name, int damage) {
            Health = health;
            Name = name;
            Damage = damage;
        }

        /// <summary>
        /// returns damage
        /// </summary>
        /// <returns>int damage</returns>
        public int GetDamage() {
            return Damage;
        }

        public void AlienToString() {
            Console.WriteLine("{0}, {1} health", Name, Health);
        }

    }
}
