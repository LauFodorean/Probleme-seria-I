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

        [TestMethod]
        public void FiveOfFourtyTest()
        {
            Assert.AreEqual(13983816, ChansesCalculation(5, 40));
        }

        public long ChansesCalculation(int numbersInCombination, int numbersToChoseFrom)
        {

            int a = numbersToChoseFrom - numbersInCombination;
            long chansesOfWin = Factorial(numbersToChoseFrom) / (Factorial(numbersInCombination) * Factorial(a));
            return chansesOfWin;
        }

        public long Factorial(int number)
        {
            long factorial = 1;
            for (int i = 1; i <= number; i++)
                factorial = factorial * i;
            return factorial;
        }
    }
}
