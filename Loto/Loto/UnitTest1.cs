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
            return 0;
        }
    }
}
