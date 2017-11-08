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
        public void WhenBowlingGetScore_ReturnScores(int firstScore, int SecondScore, int exceptedScore)
        {
            var Bowling = new Bowling();

            for (var i = 1; i <= Bowling.Rounds; i++)
            {
                Bowling.Roll(firstScore, SecondScore);
            }

            var expected = exceptedScore;

            Assert.AreEqual(expected, Bowling.Score());
        }
    }
}
