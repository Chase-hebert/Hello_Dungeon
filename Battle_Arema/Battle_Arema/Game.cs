using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Arema
{
    internal class Game
    {
            int Getinput(string description, string option1, string option2)
            {
                int inputreceived = 0;
                ConsoleKeyInfo key;
                while (inputreceived != 1 && inputreceived != 2)
                {
                    Console.Clear();
                    Console.WriteLine(description);
                    Console.WriteLine("1 " + option1);
                    Console.WriteLine("2 " + option2);
                    Console.WriteLine("<");

                    key = Console.ReadKey();

                    if(key.KeyChar == '1')
                    {
                        inputreceived = 1;
                    }
                    else if (key.KeyChar == '2')
                    {
                        inputreceived = 2;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input");
                        Console.ReadKey();
                    }
                }
                Console.WriteLine();
                return inputreceived;
            }
        
            Character player;
            Character enemy;

            private bool _gameOver = false;


            private void Start()
            {
            player = new Character(name: "Player", maxHealth: 100, attackPower: 10, defensePower: 5);
            enemy = new Character(name: "Blimbo", maxHealth: 100, attackPower: 8, defensePower: 3);
            player.PrintStats();
            Console.WriteLine();
            enemy.PrintStats();

            float damage = player.Attack(enemy);
            Console.WriteLine();
            Console.WriteLine(player.Name + " did " + damage + " damage to " + enemy.Name + "!!!");
            Console.WriteLine();

            player.PrintStats();
            Console.WriteLine();
            enemy.PrintStats();

            //Timer to clear the console screen to make it nicer
            Thread.Sleep(5000);
            Console.Clear();
            }

            private void Update()
            {
            float damage = enemy.Attack(player);
            Console.WriteLine(enemy.Name + " Retaliates and attacks player dealing " + damage + " damage to" + player.Name);
            Console.ReadKey();
            }

            private void End()
            {
             
            }

        public void Run()
        {
            Start();
            while (!_gameOver)
            {
                Update();
            }
            End();
        }


    }
}
