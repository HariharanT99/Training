using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.MSUnitTests
{
    [TestClass]
    public class CalculatorMsTests
    {
        [TestMethod]
        public void Addition_ReturnAddedValue()
        {
            //Arrange
            var Obj = new Calculate();

            //Act
            var result = Obj.Addition(20, 10);

            //Assert
            Assert.AreEqual(30, result);

        }

        [TestMethod]
        public void Subtraction_ReturnSubtractedValue()
        {
            //Arrange
            var Obj = new Calculate();

            //Act
            var result = Obj.Subtraction(20, 10);

            //Assert
            Assert.AreEqual(10, result);

        }

        [TestMethod]
        public void Multiplication_ReturnMultipliedValue()
        {
            //Arrange
            var Obj = new Calculate();

            //Act
            var result = Obj.Multiplication(20, 10);

            //Assert
            Assert.AreEqual(200, result);

        }

        [TestMethod]
        public void Division_ReturnDividedValue()
        {
            //Arrange
            var Obj = new Calculate();

            //Act
            var result = Obj.Division(20, 10);

            //Assert
            Assert.AreEqual(2, result);

        }
    }
}
