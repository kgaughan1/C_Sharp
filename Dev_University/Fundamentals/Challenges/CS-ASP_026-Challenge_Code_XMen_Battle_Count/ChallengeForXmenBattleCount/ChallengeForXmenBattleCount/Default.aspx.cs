using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            int min = 20;
            int max = 0;

            int min_index = 0;
            int max_index = 0;


            // Your Code Here!

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    max_index = i;
                }

                if ( numbers[i] < min)
                {
                    min = numbers[i];
                    min_index = i;
                }
            }

            result = String.Format("{0} has the fewest battles.  {1} has the most battles.", names[min_index], names[max_index]);


            resultLabel.Text = result;
        }
    }
}