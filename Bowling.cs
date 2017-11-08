using System.Collections.Generic;

namespace Bowling
{
    public class Bowling
    {
        public readonly int Rounds = 10;


        private List<RollOfRound> rolls = new List<RollOfRound>();
        private readonly int maxScoreOfRound = 10;
        private int score;

        public void Roll(int firstScore, int secondScore)
        {
            rolls.Add(new RollOfRound
            {
                FirstScore = firstScore,
                SecondScore = secondScore
            });
        }

        public int Score()
        {
            for (int i = 0; i < 10; i++)
            {
                var sumScore = rolls[i].FirstScore + rolls[i].SecondScore;
                if (sumScore == maxScoreOfRound)
                {
                    sumScore += rolls[i + 1].FirstScore;
                }

                score += sumScore;
            }

            return score;
        }

        public class RollOfRound
        {
            public int FirstScore { get; set; }
            public int SecondScore { get; set; }
        }
    }
}