using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Game
    {
        public string Play(List<Card> player1, List<Card> player2, string result)
        {

            for (int i = 0; i < player1.Count; i++)
            {
                if ( player1.Count == i || player2.Count == i)
                {
                    return result;
                }
                if ( player1[i].Value > player2[i].Value)
                {
                    player1.Add(player2[i]);
                    result += String.Format("Round {0}: Player1 wins the round with {1} over {2} <br />", i, player1[i].Value, player2[i].Value);
                }
                else if (player2[i].Value > player1[i].Value)
                {
                    player2.Add(player1[i]);
                    result += String.Format("Round {0}: Player2 wins the round with {1} over {2} <br />", i, player2[i].Value, player1[i].Value);
                }
                else
                {
                    result += String.Format("<h2>Battle!!!!!!!!!!</h2><br/>");

                    if ( i + 4 > player1.Count)
                    {
                        result += "Player 1 Loses!";
                        return result;
                    }
                    else if (i + 4 > player2.Count)
                    {
                        result += "Player 2 Loses!";
                        return result;
                    }
                    else if (player1[i+3].Value > player2[i+3].Value)
                    {
                        player1.Add(player2[i]);
                        player1.Add(player2[i+1]);
                        player1.Add(player2[i+2]);
                        player1.Add(player2[i+3]);
                        //result += String.Format("Round {0}: Player1 wins the battle round with {1} over {2}<br/>", i, player1[i+3].Value, player2[i+3].Value);
                        i = i + 3;
                    }
                    else
                    {
                        player2.Add(player1[i]);
                        player2.Add(player1[i + 1]);
                        player2.Add(player1[i + 2]);
                        player2.Add(player1[i + 3]);
                        //result += String.Format("Round {0}: Player2 wins the battle round with {1} over {2}<br />", player2[i + 3].Value, player1[i + 3].Value);
                        i = i + 3;
                    }
                }
            }

            return result;
        }
    }
}