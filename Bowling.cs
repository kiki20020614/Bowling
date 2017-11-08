namespace Bowling
{
    public class Bowling
    {
        public readonly int Rounds = 10;
        private int scores;

        public int Roll(int first, int second)
        {
            scores = scores + first + second;
            return scores;
        }

        public int Scores()
        {
            return scores;
        }
    }
}