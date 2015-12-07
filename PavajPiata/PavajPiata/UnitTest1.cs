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
            Assert.AreEqual(3, OneDirectionPavemetCalculation(25, 10, 10));
        }

        [TestMethod]
        public void NumberOfPavemetsOnSquareTestMethod()
        {
            Assert.AreEqual(6, OneDirectionPavemetCalculation(25, 15, 10));
        } 

        public int OneDirectionPavemetCalculation(double lenghtSquareDimension, double widthSquareDimension, int pavementDimension)
        {
            double numberOfPavementsOnLenght = lenghtSquareDimension / pavementDimension;
            numberOfPavementsOnLenght = Math.Ceiling(numberOfPavementsOnLenght);
            double numberOfPavementsOnWidth = widthSquareDimension / pavementDimension;
            numberOfPavementsOnWidth = Math.Ceiling(numberOfPavementsOnWidth);
            int numberOfPavements = (int)numberOfPavementsOnLenght * (int)numberOfPavementsOnWidth;
            return numberOfPavements; 
        }
    }
}
