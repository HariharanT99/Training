using NUnit.Framework;
using Testing;
using System;

namespace TestorLibrary
{
    public class TestClass
    {
        private Logic _logic;
        [SetUp]
        public void Setup()
        {
            _logic = new Logic(); 
        }

        [Test]
        public void Tri_ThrowError_Side_Zero()
        {
            //Arrange
            var side1 = 0;
            var side2 = 10;
            var side3 = 11;

            //Act
            var result = _logic.AreaofTraiangle(side1, side2, side3);

            //Assert
            var exception = Assert.Throws<Exception>(() => _logic.AreaofTraiangle(side1, side2, side3));
            //var excepted = new Exception("Sides should not contains zero and negative values");
            Assert.That(exception.Message, Is.EqualTo("Sides should not contains zero and negative values"));
        }

        [Test]
        public void Tri_ThrowError_Side_Negative()
        {
            //Arrange
            var side1 = 20;
            var side2 = 10;
            var side3 = -11;

            //Act
            var result = _logic.AreaofTraiangle(side1, side2, side3);

            //Assert
            var exception = Assert.Throws<Exception>(() => _logic.AreaofTraiangle(side1, side2, side3));
            //var excepted = new Exception("Sides should not contains zero and negative values");
            Assert.That(exception.Message, Is.EqualTo("Sides should not contains zero and negative values"));
        }

        [Test]
        public void Tri_Checkfor_Value()
        {
            //Arrange
            var side1 = 21;
            var side2 = 10;
            var side3 = 12;

            //Act
            var result = _logic.AreaofTraiangle(side1, side2, side3);

            //Assert
            Assert.AreEqual(34.270067114028244d, result);
        }

        [Test]
        public void Cel_Checkfor_Zero()
        {
            //Arrange
            var fah = 0;

            //Act
            var result = _logic.ConverToCelsius(fah);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Cel_Checkfor_NegativeValue()
        {
            //Arrange
            var fah = -10;

            //Act
            var result = _logic.ConverToCelsius(fah);

            //Assert
            Assert.AreEqual(-23.3333, result);
        }


    }
}