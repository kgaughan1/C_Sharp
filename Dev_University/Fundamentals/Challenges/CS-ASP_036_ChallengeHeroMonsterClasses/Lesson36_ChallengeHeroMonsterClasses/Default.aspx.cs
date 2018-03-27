using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson36_ChallengeHeroMonsterClasses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            Character monster = new Character();

            hero.Name = "Kevin";
            hero.Health = 100;
            hero.DamageMaximum = 20;
            hero.AttackBonus = 20;

            monster.Name = "Megan";
            monster.Health = 200;
            monster.DamageMaximum = 5;
            monster.AttackBonus = 10;

            monster.Defend(hero.Attack());

            hero.Defend(monster.Attack());

            displayStats(hero, monster);
        }

        public void displayStats(Character hero, Character monster)
        {
            outputLabel.Text = String.Format("Hero Health is {0}.  The Monster health is {1}.", hero.Health, monster.Health);
        }

    }

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