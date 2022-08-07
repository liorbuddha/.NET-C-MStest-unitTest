using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tar01;




namespace UnitTestProject1
{
    [TestClass]
    public class Calculator_Test
    {
        [TestMethod]
     
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
        [TestMethod]

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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        
        public void Demo()
        {
            // Arrange
       

            // Act

            //Assert
        }





        [TestMethod]
      
        [DataRow(2, 7, 9,false)]
        [DataRow(2, 7, 100, true)]
        public void Add_double(double x, double y,double z, bool a)
        {
            
            Calculator calc = new Calculator();
            double result = calc.Add(x, y, a);

            Assert.AreEqual(z, result);
        }















    }
}
