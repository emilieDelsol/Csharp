using System;

namespace DojoTddBowlingTests
{
	public class BowlingGame
	{
        private int score;

        public void Roll(int pins)
        {
            score += pins;
        }

        public int Score()
        {
            return score;
        }

    }
}