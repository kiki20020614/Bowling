using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Bowling
{
    [TestFixture]
    public class BowlingTest
    {
        [Test]
        public void WhenBowlingGutterBall_Return0()
        {
            var Bowling = new Bowling();

            for (var i = 1; i <= Bowling.Rounds; i++)
            {
                Bowling.Roll(0, 0);
            }

            var expected = 0;

            Assert.AreEqual(expected, Bowling.Score());
        }

        [TestCase(3, 0, 30)]
        [TestCase(3, 2, 50)]
        [TestCase(4, 5, 90)]
        public void WhenBowlingGetScore_ReturnScore(int firstScore, int SecondScore, int exceptedScore)
        {
            var Bowling = new Bowling();

            for (var i = 1; i <= Bowling.Rounds; i++)
            {
                Bowling.Roll(firstScore, SecondScore);
            }

            var expected = exceptedScore;

            Assert.AreEqual(expected, Bowling.Score());
        }

        [Test]
        public void WhenBowlingGetSpare_ReturnScore()
        {
            var Bowling = new Bowling();

            Bowling.Roll(1, 0); //1
            Bowling.Roll(1, 9); //0 -> 11 + 1 = 12
            Bowling.Roll(1, 0); //13
            Bowling.Roll(1, 0); //14
            Bowling.Roll(1, 0); //15
            Bowling.Roll(1, 0); //16
            Bowling.Roll(1, 0); //17
            Bowling.Roll(1, 0); //18
            Bowling.Roll(1, 0); //19
            Bowling.Roll(1, 0); //20

            var expected = 20;

            Assert.AreEqual(expected, Bowling.Score());
        }

        [Test]
        public void WhenBowlingGetStrike_ReturnScore()
        {
            var Bowling = new Bowling();

            Bowling.Roll(1, 0); //1
            Bowling.Roll(10, 0); //0 -> 11 + 1 = 12
            Bowling.Roll(1, 0); //13
            Bowling.Roll(1, 0); //14
            Bowling.Roll(10, 0); //25
            Bowling.Roll(1, 0); //26
            Bowling.Roll(1, 0); //27
            Bowling.Roll(1, 0); //28
            Bowling.Roll(1, 0); //29
            Bowling.Roll(1, 0); //30

            var expected = 30;

            Assert.AreEqual(expected, Bowling.Score());
        }

        [Test]
        public void WhenBowling10RoundGetFirstStrike_ReturnScore()
        {
            var Bowling = new Bowling();

            Bowling.Roll(1, 0); //1
            Bowling.Roll(10, 0); //0 -> 11 + 1 = 12
            Bowling.Roll(1, 0); //13
            Bowling.Roll(1, 0); //14
            Bowling.Roll(10, 0); //25
            Bowling.Roll(1, 0); //26
            Bowling.Roll(1, 0); //27
            Bowling.Roll(1, 0); //28
            Bowling.Roll(1, 0); //29

            Bowling.Roll(10, 0); //46
            Bowling.Roll(4, 3); 

            var expected = 46;

            Assert.AreEqual(expected, Bowling.Score());
        }

        [Test]
        public void WhenBowling10RoundGetFirstSpare_ReturnScore()
        {
            var Bowling = new Bowling();

            Bowling.Roll(1, 0); //1
            Bowling.Roll(10, 0); //0 -> 11 + 1 = 12
            Bowling.Roll(1, 0); //13
            Bowling.Roll(1, 0); //14
            Bowling.Roll(10, 0); //25
            Bowling.Roll(1, 0); //26
            Bowling.Roll(1, 0); //27
            Bowling.Roll(1, 0); //28
            Bowling.Roll(1, 0); //29

            Bowling.Roll(3, 7); //43
            Bowling.Roll(4, 0); //Sencond = -

            var expected = 43;

            Assert.AreEqual(expected, Bowling.Score());
        }

        [Test]
        public void WhenBowling10RoundGetSecondStrike_ReturnScore()
        {
            var Bowling = new Bowling();

            Bowling.Roll(1, 0); //1
            Bowling.Roll(10, 0); //0 -> 11 + 1 = 12
            Bowling.Roll(1, 0); //13
            Bowling.Roll(1, 0); //14
            Bowling.Roll(10, 0); //25
            Bowling.Roll(1, 0); //26
            Bowling.Roll(1, 0); //27
            Bowling.Roll(1, 0); //28
            Bowling.Roll(1, 0); //29

            Bowling.Roll(10, 0); //49
            Bowling.Roll(10, 0); //
            Bowling.Roll(3, 0); //Sencond = -

            var expected = 52;

            Assert.AreEqual(expected, Bowling.Score());
        }
    }
}
