using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [TestFixture]
    public class TestClass
    {
        Game game;  

        [SetUp]
        public void setUp()
        {
            game = new Game();
        }


        [Test]
        public void WhenGetZeroShouldBeZero()
        {

            game.rolle(0);
            var res = game.GetScore();
            Assert.That(res, Is.EqualTo(0));
        }

        [Test]
        public void WhenGetLessThanTenGetTheSumOfThis()
        {
            game.rolle(1);
            game.rolle(5);
            var res = game.GetScore();
            Assert.That(res, Is.EqualTo(6));
        }

        [Test]
        public void WhenIGotTenInTheFrameShouldGotTheSumOfTheNextBall()
        {
            game.rolle(5);
            game.rolle(5);
            game.rolle(3);

            var res = game.GetScore();
            Assert.That(res, Is.EqualTo(16));

        }


        [Test]
        public void WhenIGotTenInTheDiffrantFrameShouldNotGotTheSumOfTheNextBall()
        {
            game.rolle(3);
            game.rolle(5);
            game.rolle(5);
            game.rolle(3);

            var res = game.GetScore();
            Assert.That(res, Is.EqualTo(16));

        }


        [Test]
        public void WhenGotTenInTheFirstShot()
        {
            game.rolle(10);
            game.rolle(2);
            game.rolle(3);

            var res = game.GetScore();
            Assert.That(res, Is.EqualTo(20));

        }

        [Test]
        public void GetMaxScore()
        {
            for (int i = 0; i < 12; i++)
            {
                game.rolle(10);
            }
            var res = game.GetScore();
            Assert.That(res, Is.EqualTo(300));
        }
    }
}
