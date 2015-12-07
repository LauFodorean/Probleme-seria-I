using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PavajPiata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumberOfPavemetsOnSquareLenghtTestMethod()
        {
            Assert.AreEqual(3, OneDirectionPavemetCalculation(25, 15, 10));
        }

        public int OneDirectionPavemetCalculation(double lenghtSquareDimension, double WidthSquareDimension, int pavementDimension)
        {
            double numberOfPavements = lenghtSquareDimension / pavementDimension;
            numberOfPavements = Math.Ceiling(numberOfPavements);
            return (int)numberOfPavements; 
        }
    }
}
