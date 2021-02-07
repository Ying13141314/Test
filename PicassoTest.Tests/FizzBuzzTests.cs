using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PicassoTest.Tests
{
    public class FizzBuzzTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetOutput_IsDivisibleBy3_ReturnsFizz()
        {
            //Arrange
            var tres = 3;
            var FizzBuzz = new FizzBuzz();

            //Act
            var result = FizzBuzz.GetOutput(tres);

            //Assert
            Assert.AreEqual(result,"Fizz");
        }

        [Test]
        public void GetOutput_IsDivisibleBy5_ReturnsBuzz()
        {
            //Arrange
            var cinco = 5;
            var FizzBuzz = new FizzBuzz();

            //Act
            var result = FizzBuzz.GetOutput(cinco);

            //Assert
            Assert.AreEqual(result, "Buzz");
        }

        [Test]
        public void GetOutput_IsDivisibleBy5and3_ReturnsFizzBuzz()
        {
            //Arrange
            var numero = 15;
            var FizzBuzz = new FizzBuzz();

            //Act
            var result = FizzBuzz.GetOutput(numero);

            //Assert
            Assert.AreEqual(result, "FizzBuzz");
        }

        [Test]
        public void GetOutput_notDivisibleBy5and3_ReturnsBuzz()
        {
            //Arrange
            var numero = 7;
            var FizzBuzz = new FizzBuzz();

            //Act
            var result = FizzBuzz.GetOutput(numero);

            //Assert
            Assert.AreEqual(result, numero.ToString());
        }

    }
}
