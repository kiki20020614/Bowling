namespace Bowling
{
    public class Bowling
    {
        public readonly int Rounds = 10;
        private int score;

        public int Roll(int first, int second)
        {
            score = score + first + second;
            return score;
        }

        public int Score()
        {
            return score;
        }
    }
}