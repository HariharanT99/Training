using NUnit.Framework;
using System;
using CalculatorTesting;

namespace CalculatorTestor
{
    [TestFixture]
    public class Testor
    {

        [Test]
        public void TestAdd()
        {
            Calculator Obj = new Calculator();
            int num1 = 20;
            int num2 = 10;
            Assert.AreEqual(30, Obj.Addition(num1, num2));   //Assert , Act
        }

        [Test]
        public void TestSub()
        {
            Calculator Obj = new Calculator();

            //Arrange
            int num1 = 20;
            int num2 = 10;
            Assert.AreEqual(10, Obj.Subtraction(num1, num2));   //Assert , Act
        }

        [Test]
        public void TestMultiply()
        {
            Calculator Obj = new Calculator();

            //Arrange
            int num1 = 20;
            int num2 = 10;
            Assert.AreEqual(200, Obj.Multiplication(num1, num2));   //Assert , Act
        }

        [Test]
        public void TestDivide()
        {
            Calculator Obj = new Calculator();

            //Arrange
            int num1 = 20;
            int num2 = 10;
            Assert.AreEqual(2, Obj.Division(num1, num2));   //Assert , Act
        }

    }
}
