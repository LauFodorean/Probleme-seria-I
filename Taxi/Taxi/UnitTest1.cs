using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taxi
{
    [TestClass]
    public class TaxiTest
    {
        [TestMethod]
        public void DayFeeCalculation()
        {
            double fee = TaxiFeeCalculation(10, 9);
            Assert.AreEqual(50, fee);
        }

        public double TaxiFeeCalculation(double distance, int hour)
        {
            return 0;
        }
    }
}
