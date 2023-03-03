﻿using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTests
{
    [TestClass]
    public class GameTests
    {
        private Game game;

        [TestInitialize]
        public void Initialize()
        {
            game = new Game();
        }

        [TestMethod]
        public void TestAllGutterballs()
        {
            RollMany(20, 0);

            Assert.AreEqual(0, game.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            RollMany(20, 1);

            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        public void TestOneSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(17,0);
            
            Assert.AreEqual(16,game.Score());
        }
        
        private void RollMany(int numberOfRolls, int pins)
        {
            for (int i = 0; i < numberOfRolls; i++)
                game.Roll(pins);
        }
    }
}
