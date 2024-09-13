using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battle_arena
{
    struct Monster
    {
        public string name;
        public float health;
        public float attack;
        public float defense;

        public Monster(
            string name,
            float health,
            float attack,
            float defense)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.defense = defense;
        }
    }
    internal class Game
    {
        //Monster1
        Monster _monster1;

        // Monster 2
        Monster _monster2;

        void Start()
        {
            _monster1 = new Monster("schrimbo", 20, 10, 5);
            _monster2 =new Monster("scleck", 30, 8, 8);
            PrintStats(_monster1);
            PrintStats(_monster2);
        }
        void Update()
        {
            while (_monster1.health > 0 && _monster2.health > 0)
            {



                // Monster 1 attacks monster 2
                Console.WriteLine(_monster2.name + " has taken " + Fight(_monster1, ref _monster2) + "damage!");

                // Monster 2 counter attacks

                Console.WriteLine(_monster1.name + " has taken " + Fight(_monster2, ref _monster1) + "damage!");

                PrintStats(_monster1);
                PrintStats(_monster2);
            }
        }
        void End()
        {
            Console.ReadKey();
        }
        public void Run()
        {



            Console.ReadKey();
        }

        float CalculateDamage(float attack, float defense)
        {
            float damage = attack - defense;
            // damage clamp 1
            if(damage <= 0)
            {
                damage = 0;
            }
            // damage clamp 2
            damage = Math.Max(0, damage);
            return damage;
        }

        float Fight (Monster attacker, ref Monster defender)
        {
            float damageTaken = CalculateDamage(attacker.attack, defender.defense);
            defender.health -= damageTaken;
            return damageTaken;
        }
        void PrintStats(Monster monster)
        {
            Console.WriteLine("Name:    " + monster.name);
            Console.WriteLine("Health:  " + monster.health);
            Console.WriteLine("attack:  " + monster.attack);
            Console.WriteLine("defense: " + monster.defense);
        }
    }
}
