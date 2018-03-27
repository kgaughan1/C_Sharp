using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson_45_ChallengeSimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {

            Darts Player1 = new Darts(random);
            Darts Player2 = new Darts(random);
            outputLabel.Text = String.Format("Player1 has {0} points and Player2 has {1} points.<br />", Player1.PlayerScore.ToString(), Player2.PlayerScore.ToString());

            while (Player1.PlayerScore < 300 && Player2.PlayerScore < 300)
            {
                Player1.Throw();
                Player1.Throw();
                Player1.Throw();
                Player2.Throw();
                Player2.Throw();
                Player2.Throw();
                outputLabel.Text += String.Format("Player1 has {0} points and Player2 has {1} points.<br />", Player1.PlayerScore.ToString(), Player2.PlayerScore.ToString());
            }

            int player1 = Player1.PlayerScore;
            int player2 = Player2.PlayerScore;

            outputLabel.Text += String.Format("Player1 has {0} points and Player2 has {1} points.<br />", player1.ToString(), player2.ToString());
        }
    }
}