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
        public void Run()
        {
            //Monster1
            Monster monster1 = new Monster("schrimbo",20,10,5);

            // Monster 2
            Monster monster2 = new Monster("scleck",10,3,20);

            PrintStats(monster1);
            PrintStats(monster2);
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
