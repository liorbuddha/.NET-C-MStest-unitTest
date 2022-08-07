using NUnit.Framework;
using Tar01;


namespace UnitTestProject1
{
    [TestFixture]
    public class CalculatorTest_Nunit
    {
        [Test]

        public void Add_12Add3_return15()
        {
            // Arrange
            double x = 12;
            double y = 3;
            double Expected = 15;
            Calculator calc = new Calculator();

            // Act
            double ActualResult = calc.Add(x, y);

            //Assert
            Assert.AreEqual(Expected, ActualResult);
        }
        [Test]

        public void Sub_12Sub3_return9()
        {
            // Arrange
            double x = 12;
            double y = 3;
            double Expected1 = 9;
            Calculator calc1 = new Calculator();

            // Act
            double ActualResult1 = calc1.Sub(x, y);

            //Assert
            Assert.AreEqual(Expected1, ActualResult1);
        }
        [Test]
        public void Mul_12Mul3_return36()
        {
            // Arrange
            double x = 12;
            double y = 3;
            double Expected = 36;
            Calculator calc = new Calculator();

            // Act
            double ActualResult = calc.Mul(x, y);

            //Assert
            Assert.AreEqual(Expected, ActualResult);
        }
        [Test]
        public void Div_12Div3_return4()
        {
            // Arrange
            double x = 12;
            double y = 3;
            double Expected = 4;
            Calculator calc = new Calculator();

            // Act
            double ActualResult = calc.Div(x, y);

            //Assert
            Assert.AreEqual(Expected, ActualResult);
        }
    }
}