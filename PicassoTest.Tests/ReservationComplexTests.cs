using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PicassoTest.Tests
{
    class ReservationComplexTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PayReservation_UserIsNull_ThrowsNullException()
        {
            //Arrange
            var paco = new UserComplex();
            var pepe = new UserComplex();
            var ReservationComplex = new ReservationComplex { MadeBy = paco };

            //Act
            Assert.Throws<ArgumentNullException>(() => ReservationComplex.PayReservation(null));
        }

        [Test]
        public void PayReservation_NotSameUser_Return2()
        {
            //Arrange
            var paco = new UserComplex();
            var pepe = new UserComplex();
            var ReservationComplex = new ReservationComplex { MadeBy = paco };

            //Act
            var result = ReservationComplex.PayReservation(pepe);

            //Assert
            Assert.AreEqual(result,2);
        }

        [Test]
        public void PayReservation_NotMoney_Return1()
        {
            //Arrange
            var paco = new UserComplex {Money=90};
            var ReservationComplex = new ReservationComplex { MadeBy = paco,Price=100 };

            //Act
            var result = ReservationComplex.PayReservation(paco);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void PayReservation_HasMoney_Return0()
        {
            //Arrange
            var paco = new UserComplex { Money = 150 };
            var ReservationComplex = new ReservationComplex { MadeBy = paco, Price = 100 };

            //Act
            var result = ReservationComplex.PayReservation(paco);

            //Assert
            Assert.AreEqual(result, 0);
            Assert.AreEqual(paco.Money, 50);
        }
    }
}
