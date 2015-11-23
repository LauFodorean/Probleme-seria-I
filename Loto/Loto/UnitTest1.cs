using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class LotoUnitTest
    {
        [TestMethod]
        public void TwoOfSixTestMethod()
        {
            int numberOfVariants = VariantsCalculation( 6 , 2);
            Assert.AreEqual( 15 , numberOfVariants );
        }

        public int VariantsCalculation(int totalNumbers, int combinationNumber)
        {
            int numberOfVariants = 0;
            for (int i = 1; i <= (totalNumbers - combinationNumber + 1); i++)
                numberOfVariants = numberOfVariants + i;
            return numberOfVariants;
        }
    }
}
