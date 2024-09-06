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
            //Role selection
            Console.WriteLine("Entering the dungeon of spelk you must choose a class either A Mindflayer or Pyromancer");
            Console.Write("1|2");
            int input = getinput("Are you a Mindflayer or a Pyromancer", "Mindflayer", "Pyromacer");
            if(input == 1)
            {
                playerRole = "Mindflayer";
            }
            else if (input == 2)
            {
                playerRole = "Pyromancer";
            }
                Console.WriteLine("you have now picked your class " + playerRole);
                Console.WriteLine();
                Console.WriteLine("You now enter the dungeon and are now greeted by an elderly merchant,");
                Console.WriteLine();
                Console.WriteLine("Hello traveler would you like to peruse my goods");
                Console.Write("yes|no");
                // merchant options and code for battle
                bool merchantBattle = false;
                input = getinput("Yes or No", "yes", "no");
                {
                    if (playerRole == "Mindflayer" && input == 1)
                    {
                        Console.WriteLine("1. Staff of Weak Confusion(3g)");
                        Console.WriteLine("2. Rusty Dagger(2g) (Not optimal for class)");
                        Console.WriteLine("3. stat upgrade(8g)");
                    }
                    else if(playerRole == "Pyromancer" && input == 1 )
                    {
                        Console.WriteLine("1. wand of minor burning(3g)");
                        Console.WriteLine("2. Rusty Dagger(2g) (Not optimal for class)");
                        Console.WriteLine("3. stat upgrade(8g)");
                    }
                }
                if (input == 2)
                {
                    Console.WriteLine("YOU HAVE CHOSEN POORLY");
                    merchantBattle = true;
                }
            int input2 = threechoiceinput("Merchant options", "staff", "dagger", "stat");
            if (merchantBattle == false)
            {
                while(input2 == 1 || input2 == 2 || input2 == 3 && input != 2)
                Console.WriteLine("1|2|3");
            }














        }
    int getinput(string description, string option1, string option2)
    {
        string input = "";
        int inputreceived = 0;

        // input loop
        while (inputreceived != 1 && inputreceived != 2)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            input = Console.ReadLine();

            if (input == "1" || input == option1)
            {
                inputreceived = 1;
            }
            else if (input == "2" || input == option2)
            {
                inputreceived = 2;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.ReadKey();
            }


        }

        Console.Clear();
        return inputreceived;
    }

        int threechoiceinput(string description, string option1, string option2, string option3)
        {
            string input = "";
            int inputreceived = 0;

            // 3 choice input loop
            while(inputreceived != 1 && inputreceived != 2 && inputreceived != 3)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                input = Console.ReadLine();

                if (input == "1" || input == option1)
                {
                    inputreceived = 1;
                }
                else if (input == "2" || input == option2)
                {
                    inputreceived = 2;
                }
                else if (input == "3" || input == option3)
                {
                    inputreceived = 3;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }
                   
            }

            Console.Clear();
            return inputreceived;
        }        


            
    }   

    
    
} 

