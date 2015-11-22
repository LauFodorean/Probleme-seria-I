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

        [TestMethod]
        public void DayFeeCalculationLongDistance()
        {
            double fee = TaxiFeeCalculation(100, 9);
            Assert.AreEqual(600, fee);
        }

        [TestMethod]
        public void NightFeeCalculationShortDistance()
        {
            double fee = TaxiFeeCalculation(10, 7);
            Assert.AreEqual(70, fee);
        }

        public double TaxiFeeCalculation(double distance, int hour)
        {
            double fee = 0;
            if (hour >= 8 & hour < 21)
                if (distance <= 21)
                fee = distance * 5;
                else
                    if (distance <=60)
                        fee = distance * 4 * 2;
                    else
                        fee = distance * 3 * 2;
            if (hour < 8 & hour <= 21)
                if (distance <= 21)
                    fee = distance * 7;
            return 0;
        }
    }
}
