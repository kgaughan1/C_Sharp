using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonster
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public int AttackBonus { get; set; }

        public int Attack()
        {
            Random random = new Random();

            int damage = random.Next(0, this.DamageMaximum);

            return damage;
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }
}
