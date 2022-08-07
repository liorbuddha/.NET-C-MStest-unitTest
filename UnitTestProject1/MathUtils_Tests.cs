using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tar01;




namespace UnitTestProject1
{
    [TestClass]
    public class MathUtils_Tests
    {
        [TestMethod]
        public void IsEven_Even_returnTrue()
        {
           
            // Arrange
            int num = 8;
            MathUtils MU = new MathUtils();
          

            // Act
             bool result = MU.IsEven(num);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsEven_Odd_returnFalse()
        {

            // Arrange
            int num = 7;
            MathUtils MU = new MathUtils();


            // Act
            bool result = MU.IsEven(num);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsPrime_17_returnsTrue()
        {

            // Arrange
            int num = 17;
            MathUtils MU = new MathUtils();


            // Act
            bool result = MU.IsPrime(num);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsPrime_16_returnsfalse()
        {

            // Arrange
            int num = 16;
            MathUtils MU = new MathUtils();


            // Act
            bool result = MU.IsPrime(num);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsPrime_minus16_returnsfalse()
        {

            // Arrange
            int num = -16;
            MathUtils MU = new MathUtils();


            // Act
            bool result = MU.IsPrime(num);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow(2,5,32,DisplayName ="Power_2Pow5_return32")]
        [DataRow(2, 7, 128)]
        [DataRow(4, 2, 16)]
        public void Power_XPowY(double x, double y,double expresult)
        {

            // Arrange
        
            MathUtils MU = new MathUtils();


            // Act
             double result = MU.pow(x, y);
            //Assert
            Assert.IsTrue(result == expresult);
        }
    }
}
