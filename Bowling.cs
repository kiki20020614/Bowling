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
                if (rolls[i].FirstScore == maxScoreOfRound || rolls[i].SecondScore == maxScoreOfRound)
                {
                    sumScore += rolls[i + 1].FirstScore + rolls[i + 1].SecondScore;

                    if (i == Rounds - 1 && (rolls[i + 1].FirstScore == maxScoreOfRound || rolls[i + 1].SecondScore == maxScoreOfRound))
                    {
                        sumScore += rolls[i + 2].FirstScore + rolls[i + 2].SecondScore;
                    }
                }
                else if (sumScore == maxScoreOfRound)
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