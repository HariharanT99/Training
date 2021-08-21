using NUnit.Framework;
using Calculator;

namespace Calculator.UnitTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        //Arrange
        Calculate Obj = new Calculate();
        int num1 = 20;
        int num2 = 10;

        [Test]
        public void TestAdd()
        {
            //Act
            var result = Obj.Addition(num1, num2);

            //Assert
            Assert.AreEqual(30, result);
        }

        [Test]
        public void TestSub()
        {
            //Act
            var result = Obj.Subtraction(num1, num2);

            //Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void TestMultiply()
        {
            //Act
            var result = Obj.Multiplication(num1, num2);

            //Assert
            Assert.AreEqual(200, result);
        }

        [Test]
        public void TestDivide()
        {
            //Act
            var result = Obj.Division(num1, num2);

            //Assert
            Assert.AreEqual(2, result);
        }
    }
}