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
            string playerName = "egregious";
            float playerHealth = 10.0f;
            float playerMana = 8.0f;
            int goldAmt = 12;
            int goldGain;
            int goldLoss = (goldAmt - X);
            string input = Console.ReadLine();
            { if (input != "1")
                goldLoss = -6;
            }
                
            { if (input != "2")
                    goldLoss = -12;
            }
        
            int X = goldLoss;
           
            Console.WriteLine("Hello," + playerName);
            Console.WriteLine();
            Console.WriteLine("Welcome to Pikmin 8 your gonna hate it");
            Console.WriteLine();
            Console.WriteLine("Health, " + playerHealth);
            Console.WriteLine("Mana, " + playerMana);
            Console.WriteLine("Gold, " + goldAmt);
            Console.WriteLine();
            Console.WriteLine("as you enter you realize there's a paywall either pay 6 gold for the first Floor Or 12 gold For the whole game Which will you choose");
            



        }
    }
}
