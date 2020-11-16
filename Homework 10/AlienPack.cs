using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_10 {
   class AlienPack {

        //instance list
        public List<Alien> Aliens { get; set; }

        public AlienPack() { }
        public AlienPack(List<Alien> aliens) {
            Aliens = aliens;
        }

        /// <summary>
        /// Adds an alien to the list
        /// </summary>
        /// <param name="alien">alien to add</param>
        public void AddAlien(Alien alien) {
            Aliens.Add(alien);
        }

        /// <summary>
        /// prints all aliens
        /// </summary>
        public void PrintAliens() {
            //loop through and print each alien
            foreach (Alien alien in Aliens) {
                alien.AlienToString();
            }
        }

        /// <summary>
        /// returns total damage from all aliens
        /// </summary>
        /// <returns>int damage</returns>
        public int CalculateDamage() {

            //totaldamage variable
            int totalDamage = 0;

            //calculate damage
            foreach (Alien alien in Aliens) {
                totalDamage += alien.GetDamage();
            }

            return totalDamage;

        }

    }
}
