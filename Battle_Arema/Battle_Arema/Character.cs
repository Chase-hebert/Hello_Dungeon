using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Arema
{
    internal class Character
    {
        private string _name = "";
        private string _enemyName = "Character";
        private float _health = 100;
        private float _maxHealth = 100;
        private float _attackPower = 1;
        private float _defensePower = 1;

        public string Name {get { return _enemyName; } }
        public float MaxHealth { get { return _maxHealth; } }
        public float Health
        {
            get { return _health; }
            private set { _health = Math.Clamp(value, 0, _maxHealth); }
        }

        public float AttackPower { get { return _attackPower; } }
        public float DefensePower { get { return _defensePower; } }

        public Character(string name, string enemyName, float maxHealth, float attackPower, float defensePower)
        {
            name = PlayerName();
            _enemyName = enemyName;
            _maxHealth = maxHealth;
            _health = maxHealth;
            _attackPower = attackPower;
            _defensePower = defensePower;
        }

        public float Attack(Character other)
        {
            float damage = Math.Max(0, _attackPower - other._defensePower);
            other.TakeDamage(damage);
            return damage;
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;
        }

        public void Heal(float health)
        {
            Health += health;
        }
        public void PrintStats()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health + "/" + MaxHealth);
            Console.WriteLine("Attack Power: " + AttackPower);
            Console.WriteLine("Defense Power: " + DefensePower);
        }

        public string PlayerName()
        {
            Console.WriteLine("Enter your Name");
            string playerName = Console.ReadLine();
            while (playerName.Length > 12 == true)
            {
                playerName = Console.ReadLine();
                Console.WriteLine("Your name is too long try again");
            }
            return playerName;
        }
    }
}
