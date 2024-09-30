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

        public bool GameOver { get => _gameOver; set => _gameOver = value; }

        private void Start()
            {
            player = new Character(playerName: "", enemyName: "", maxHealth: 100, attackPower: 10, defensePower: 5); 
            enemy = new Character(playerName: "", enemyName: "Blimbo", maxHealth: 100, attackPower: 8, defensePower: 3);
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

            Console.ReadKey();
            Console.Clear();
            }

            private void Update()
            {
            float damage = enemy.Attack(player);


            Console.WriteLine(enemy.Name + " Retaliates and attacks player dealing " + damage + " damage to " + player.Name);
            CheckIfDead();
            Console.ReadKey();

            
            }

        public bool CheckIfDead()
        {
            bool isDead = false;
            if (player.Health == 0)
            {
                isDead = true;
                GameOver = true;
            }
            else
            {
                isDead = false;
            }
            return isDead;
        }

            private void End()
            {
             Console.Clear();
             Console.WriteLine("You Died");
             Console.WriteLine("\nGame Over");
             int playerRetries = Getinput("do you wish to retry", "Yes", "no");
             if (playerRetries == 1)
              {
                GameOver = false;
                Run();
              }
             else
              {
                Console.Clear();
              }
            }

        public void Run()
        {
            Start();
            while (!GameOver)
            {
                Update();
            }
            End();
        }


    }
}
