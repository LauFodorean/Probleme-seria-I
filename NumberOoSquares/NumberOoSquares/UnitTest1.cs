using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberOfSquares
{
    [TestClass]
    public class SquaresUnitTest
    {
        [TestMethod]
        public void FirstTestMethod()
        {
            int number = SquareNumberCalculation(8);
            Assert.AreEqual(204, number);
        }
            
        public int SquareNumberCalculation(int dimension)
        {
            int numberOfSquares = 0;
            for (int i = 1; i<9; i++)
            {
                numberOfSquares = numberOfSquares + i * i ;

            }
            return numberOfSquares;
        }
    }
}
