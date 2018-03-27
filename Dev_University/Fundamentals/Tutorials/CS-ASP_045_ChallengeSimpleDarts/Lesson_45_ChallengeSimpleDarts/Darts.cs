using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson_45_ChallengeSimpleDarts
{
    public class Darts
    {
        private Random _random;

        public int PlayerScore { get; set; }

        public Darts(Random random)
        {
            _random = random;
            PlayerScore = 0;
        }

        public void Throw()
        {
            int value = _random.Next(0, 20);

            if ( value == 0 ) // possible bullseye
            {
                bool bullseye = Bullseye();

                if (bullseye) PlayerScore += 50;
                else PlayerScore += 25;
            }
            else
            {
                bool multiplier3 = Multiplier3();
                bool multiplier2 = Multiplier2();

                if (multiplier3) PlayerScore += value * 3;
                else if (multiplier2) PlayerScore += value * 2;
                else PlayerScore += value;
            }
        }

        public bool Bullseye()
        {
            int value = _random.Next(1, 20);

            if (value == 1) return true;
            return false;
        }

        public bool Multiplier2()
        {
            int value = _random.Next(1, 20);

            if (value == 1) return true;
            return false;
        }

        public bool Multiplier3()
        {
            int value = _random.Next(1, 20);

            if (value == 1) return true;
            return false;
        }
    }
}