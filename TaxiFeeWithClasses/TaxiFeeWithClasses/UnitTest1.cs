using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxiFeeCalculation;

namespace TaxiFeeWithClasses
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DayFeeCalculation()
        {
            double fee = TaxiFeeCalculation(10, 9, 5, 4, 3, 7, 5, 4);
            Assert.AreEqual(50, fee);
        }

        [TestMethod]
        public void DayFeeCalculationLongDistance()
        {
            double fee = TaxiFeeCalculation(100, 9, 5, 4, 3, 7, 5, 4);
            Assert.AreEqual(600, fee);
        }

        [TestMethod]
        public void NightFeeCalculationShortDistance()
        {
            double fee = TaxiFeeCalculation(10, 7, 5, 4, 3, 7, 5, 4);
            Assert.AreEqual(70, fee);
        }

        [TestMethod]
        public void NightFeeCalculationLongDistance()
        {
            double fee = TaxiFeeCalculation(100, 7, 5, 4, 3, 7, 5, 4);
            Assert.AreEqual(800, fee);
        }

        
    }
}
