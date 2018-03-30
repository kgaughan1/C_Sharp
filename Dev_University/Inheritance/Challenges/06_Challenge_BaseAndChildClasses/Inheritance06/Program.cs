using System;
using System.Collections.Generic;

namespace Inheritance06
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player() { Name = "Bob", Strength = 20 };
            var warrior = new Warrior() { Name = "Baltek", Strength = 100, Bonus = 10 };
            var wizard = new Wizard() { Name = "Pentagorn", Strength = 50, Energy = 50 };

            var players = new List<Player>();
            players.Add(player);
            players.Add(warrior);
            players.Add(wizard);

            DoBattle(players);

            Console.ReadLine();
        }

        static void DoBattle(List<Player> players)
        {
            foreach (var player in players)
            {
                player.Attack();
                Console.WriteLine("");
            }
        }
    }

    class Player
    {
        public string Name { get; set; }
        public int Strength { get; set; }

        public virtual void Attack()
        {
            //Random rand = new Random();
            //int amount = rand.Next(1, Strength);

            var amount = GenerateRandomNumber(Strength);

            Console.WriteLine($"{Name} attacked for {amount} damage.");
        }

        protected int GenerateRandomNumber(int maxAmount)
        {
            Random random = new Random();
            return random.Next(maxAmount);
        }
    }

    class Warrior : Player
    {
        public int Bonus { get; set; }

        public override void Attack()
        {
            //Random rand = new Random();
            //int attack = rand.Next(1, Strength) + Bonus;
            int attack = GenerateRandomNumber(Strength) + Bonus;

            Console.WriteLine($"{Name} charged for {attack} damage (includes +{Bonus} bonus).");
        }
    }

    class Wizard : Player
    {
        public int Energy { get; set; }

        public override void Attack()
        {
            base.Attack();

            //Random rand = new Random();
            //int amount = rand.Next(1, 10);

            int amount = GenerateRandomNumber(10);

            Energy -= amount;

            Console.WriteLine($"Wizard {Name} depleted of {amount} energy.");

        }
    }
}

