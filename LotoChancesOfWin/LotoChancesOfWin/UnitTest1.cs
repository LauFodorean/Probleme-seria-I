using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotoChancesOfWin
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TwoOfSixChansesTest()
        {
            Assert.AreEqual(15, ChansesCalculation(2, 6));
        }

        public int ChansesCalculation(int numbersInCombination, int numbersToChoseFrom)
        {
            int chansesOfWin = Factorial(numbersToChoseFrom) / (Factorial(numbersInCombination) * Factorial(numbersToChoseFrom - numbersInCombination));
            return chansesOfWin;
        }

        private int Factorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
                factorial = factorial * i;
            return factorial;
        }
    }
}
