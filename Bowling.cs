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
            for (int i = 1; i <= 10; i++)
            {
                var arrayRound = i - 1;
                var sumScore = rolls[arrayRound].FirstScore + rolls[arrayRound].SecondScore;
                if (GetStrike(arrayRound))
                {
                    sumScore += rolls[arrayRound + 1].FirstScore + rolls[arrayRound + 1].SecondScore;

                    if (arrayRound == Rounds - 1 && (rolls[arrayRound + 1].FirstScore == maxScoreOfRound || rolls[arrayRound + 1].SecondScore == maxScoreOfRound))
                    {
                        sumScore += rolls[arrayRound + 2].FirstScore + rolls[arrayRound + 2].SecondScore;
                    }
                }
                else if (sumScore == maxScoreOfRound)
                {
                    sumScore += rolls[arrayRound + 1].FirstScore;
                }

                score += sumScore;
            }

            return score;
        }

        private bool GetStrike(int arrayRound)
        {
            return rolls[arrayRound].FirstScore == maxScoreOfRound || rolls[arrayRound].SecondScore == maxScoreOfRound;
        }

        public class RollOfRound
        {
            public int FirstScore { get; set; }
            public int SecondScore { get; set; }
        }
    }
}