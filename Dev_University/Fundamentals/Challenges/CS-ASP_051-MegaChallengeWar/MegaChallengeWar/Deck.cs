using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Deck
    {
        private Random _random = new Random();
        public List<Card> DeckOfCards { get; set; }

        public void GenerateDeckOfCards()
        {
            List<Card> deckOfCards = new List<Card>();

            while (deckOfCards.Count < 52)
            {
                int randomSuit = _random.Next(0, 4);
                int randomValue = _random.Next(2, 15);
                bool alreadyGenerated = false;
                Card newCard = new Card() { Suit = GetCardSuit(randomSuit), Value = randomValue };

                foreach (Card card in deckOfCards)
                {
                    if (newCard.Suit == card.Suit && newCard.Value == card.Value)
                    {
                        alreadyGenerated = true;
                        break;
                    }
                }

                if (!alreadyGenerated)
                {
                    deckOfCards.Add(newCard);
                }
            }

            DeckOfCards = deckOfCards;
        }

        private string GetCardSuit(int value)
        {
            if (value == 0) return "Hearts";
            if (value == 1) return "Clovers";
            if (value == 2) return "Diamonds";
            return "Spades";
        }

        /*
        private string GetCardValue(int value)
        {
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            if (value == 14) return "Ace";

            return value.ToString();
        }
        */

        public string DealCards(Player player1, Player player2)
        {
            string result = "";
            for (int i = 0; i < DeckOfCards.Count; i++)
            {
                
                Card newCard = new Card();
                newCard = DeckOfCards[i];

                if (i % 2 == 0)
                {
                    player1.PlayerCards.Add(newCard);
                    result += String.Format("Player1 received a {0} of {1}<br/>", DeckOfCards[i].Value, DeckOfCards[i].Suit);
                }
                else
                {
                    player2.PlayerCards.Add(newCard);
                    result += String.Format("Player2 received a {0} of {1}<br/>", DeckOfCards[i].Value, DeckOfCards[i].Suit);
                }
            }

            return result;
        }
    }
}