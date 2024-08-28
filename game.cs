using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dungeon
{
    internal class Game
    {
        public void Run()
        {
            Console.Beep();
            Console.WriteLine("hello what is your name");
            string playerName = Console.ReadLine();
            {
                //player name limit for funny
                while (playerName.Length > 12 == true)

                {
                    playerName = Console.ReadLine();
                   Console.WriteLine("your Name is too long try again");
                }
            } //things for the player
            float playerHealth = 10.0f;
            float playerMana = 8.0f;
            int goldAmt = 12;
            int goldGain;
            int goldLoss;
            string playerRole = "Beep for rn";
                // intro and current stats
            Console.WriteLine("Hello," + playerName);
            Console.WriteLine();
            Console.WriteLine("Welcome to the dungeon of spelk");
            Console.WriteLine();
            Console.WriteLine("Health, " + playerHealth);
            Console.WriteLine("Mana, " + playerMana);
            Console.WriteLine("Gold, " + goldAmt);
            Console.WriteLine();
            Console.WriteLine("as a dungeoneer of spelk you must pick one of the 2 roles either Mindflayer or Pyromancer");
                //Role selection
            string input = "";
            while (input != "1" && input != "2")
            {
                Console.Write("1|2 if this appears again it seems you don't have simple understanding of the prompt try again this time do it right");
                input = Console.ReadLine();

                if (input == "1")
                {
                    playerRole = "Mindflayer";
                    Console.WriteLine("You have chosen Mindflayer");
                }
                if (input == "2")
                {
                    playerRole = "Pyromancer";
                    Console.WriteLine("You have chosen Pyromancer");
                }
            }
            {
                Console.WriteLine("you have now picked your class");
                Console.WriteLine();
                Console.WriteLine("You now enter the dungeon and are now greeted by an elderly merchant,");
                Console.WriteLine();
                Console.WriteLine("Hello traveler would you like to peruse my goods");
                Console.Write("Y|N");
                input = Console.ReadLine() ;
                if (input == "Y" || input == "y")
                {
                    if (playerRole == "Mindflayer")
                    {
                        Console.WriteLine("1. Staff of Weak Confusion(3g)");
                        Console.WriteLine("2. Rusty Dagger(2g) (Not optimal for class)");
                        Console.WriteLine("3. stat upgrade(8g)");
                    }
                    else
                    {
                        Console.WriteLine("1. wand of minor burning(3g)");
                        Console.WriteLine("2. Rusty Dagger(2g) (Not optimal for class)");
                        Console.WriteLine("3. stat upgrade(8g)");
                    }
                }
                else if (input == "N" || input == "n") ;
                {
                    
                }
            }      
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }


} 

