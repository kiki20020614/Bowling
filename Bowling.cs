﻿namespace Bowling
{
    public class Bowling
    {
        public readonly int Rounds = 10;

        private readonly int maxScoreOfRound = 10;
        private int spareScore;
        private int score;

        public void Roll(int first, int second)
        {
            if (first + second == maxScoreOfRound)
            {
                spareScore = maxScoreOfRound;
            }
            else
            {
                spareScore = spareScore == maxScoreOfRound ? maxScoreOfRound + first : 0;
                score = score + first + second + spareScore;
            }
        }

        public int Score()
        {
            return score;
        }
    }
}