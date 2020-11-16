using System;
using System.Collections.Generic;

namespace Homework_10 {
    class Program {
        static void Main(string[] args) {

            //list of aliens
            List<Alien> aliensList = new List<Alien>();

            AlienPack aliens = new AlienPack(aliensList);

            //create aliens
            SnakeAlien snake1 = new SnakeAlien();
            SnakeAlien snake2 = new SnakeAlien();
            OgreAlien ogre1 = new OgreAlien();
            MarshmallowManAlien marsh1 = new MarshmallowManAlien();
            MarshmallowManAlien marsh2 = new MarshmallowManAlien();
            MarshmallowManAlien marsh3 = new MarshmallowManAlien();

            //add all aliens to alien pack
            aliens.AddAlien(snake1);
            aliens.AddAlien(snake2);
            aliens.AddAlien(ogre1);
            aliens.AddAlien(marsh1);
            aliens.AddAlien(marsh2);
            aliens.AddAlien(marsh3);

            //print list of aliens to screen
            aliens.PrintAliens();

            //calculate damage of all aliens
            Console.WriteLine("{0} damage taken.", aliens.CalculateDamage());

        }
    }
}
