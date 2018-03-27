using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeWar
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            deck.GenerateDeckOfCards();

            Player player1 = new Player();
            Player player2 = new Player();

            string result = deck.DealCards(player1, player2);

            Game game = new Game();

            result = game.Play(player1.PlayerCards, player2.PlayerCards, result);

            result += String.Format("Player1 Count: {0}, Player2 Count: {1}", player1.PlayerCards.Count.ToString(), player2.PlayerCards.Count.ToString());

            outputLabel.Text = result;
        }
    }

}
