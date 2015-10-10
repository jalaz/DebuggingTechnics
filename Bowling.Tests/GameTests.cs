using NUnit.Framework;

namespace Bowling.Tests
{
    public class GameTests
    {
        private Game g;

        [SetUp]
        public void Setup()
        {
            g = new Game();
        }

        [Test]
        public void Score_WithAll0_Scores0()
        {
            RollMany(20, 0);

            Assert.AreEqual(0, g.Score());
        }

        [Test]
        public void Score_WithAll1_Scores20()
        {
            RollMany(20, 1);

            Assert.AreEqual(20, g.Score());
        }

        [Test]
        public void Score_Spare_AddsNextRollToTheScore()
        {
            RollSpare();
            g.Roll(3);

            RollMany(17, 0);

            Assert.AreEqual(16, g.Score());
        }

        [Test]
        public void Score_WithStrike_AddsValueOfNextTwoRolls()
        {
            g.Roll(10);
            g.Roll(3);
            g.Roll(4);

            RollMany(17, 0);

            Assert.AreEqual(24, g.Score());
        }

        [Test]
        public void Score_WithAllStrikes_Returns300()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, g.Score());
        }

        private void RollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }

        private void RollMany(int rollCount, int pinsDown)
        {
            for (int i = 0; i < rollCount; i++)
                g.Roll(pinsDown);
        }
    }
}