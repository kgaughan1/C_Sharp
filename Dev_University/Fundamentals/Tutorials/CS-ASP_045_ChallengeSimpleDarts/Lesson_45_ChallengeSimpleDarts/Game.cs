using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_45_ChallengeSimpleDarts
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        Random _random;

        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player();
            _player1.Name = player1Name;

            _player2 = new Player();
            _player2.Name = player2Name;
        }

        public string Play()
        {
            while (_player1.Score < 300 && _player2.Score < 300)
            {
                playRound(_player1);
                playRound(_player2);
            }

            return displayResults();
        }

        private string displayResults()
        {
            string result = String.Format("Hallooo!");

            return result;
        }

        private void playRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Darts dart = new Darts(_random);
                dart.Throw();
                // TODO score the dart
            }
        }
    }
}