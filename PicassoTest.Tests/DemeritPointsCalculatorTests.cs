using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PicassoTest.Tests
{
    class DemeritPointsCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateDemeritPoints_NegativeSpeed_ThrowsOutOfRangeException()
        {
            //Arrange
            var numero = -2;
            var DemeritPointsCalculator = new DemeritPointsCalculator();

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => DemeritPointsCalculator.CalculateDemeritPoints(numero));
        }

        [Test]
        public void CalculateDemeritPoints_MaxSpeed_ThrowsOutOfRangeException()
        {
            //Arrange
            var numero = 301;
            var DemeritPointsCalculator = new DemeritPointsCalculator();

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => DemeritPointsCalculator.CalculateDemeritPoints(numero));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedLessSpeedLimit_Return0()
        {
            //Arrange
            var numero = 64;
            var DemeritPointsCalculator = new DemeritPointsCalculator();

            //Act
            var result = DemeritPointsCalculator.CalculateDemeritPoints(numero);

            //Assert
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void CalculateDemeritPoints_SpeedEqualSpeedLimit_Return0()
        {
            //Arrange
            var numero = 65;
            var DemeritPointsCalculator = new DemeritPointsCalculator();

            //Act
            var result = DemeritPointsCalculator.CalculateDemeritPoints(numero);

            //Assert
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIsInRange_ReturnValue()
        {
            //Arrange
            var numero = 80;
            var DemeritPointsCalculator = new DemeritPointsCalculator();

            //Act
            var result = DemeritPointsCalculator.CalculateDemeritPoints(numero);

            //Assert
            Assert.AreEqual(result,3);
        }


    }
}
