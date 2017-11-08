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

            Assert.AreEqual(expected, Bowling.Scores());
        }

        [Test]
        public void WhenBowlingGetScore_ReturnScores()
        {
            var Bowling = new Bowling();

            for (var i = 1; i <= Bowling.Rounds; i++)
            {
                Bowling.Roll(3, 0);
            }

            var expected = 30;

            Assert.AreEqual(expected, Bowling.Scores());
        }
    }
}
