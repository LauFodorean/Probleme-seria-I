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

        public double TaxiFeeCalculation(double distance, int hour, int dayShortTripFee, int dayMediumTripFee, int dayLongTripFee, int nightShortTripFee, int nightMediumTripFee, int nightLongTripFee)
        {
            double fee = 0;
            if (hour >= 8 & hour < 21)
            {
                if (distance <= 21)
                    fee = distance * dayShortTripFee;
                else
                    if (distance <= 60)
                        fee = TwoWay(distance) * dayMediumTripFee;
                    else
                        fee = TwoWay(distance) * dayLongTripFee;
            }
            else
            {
                if (distance <= 21)
                    fee = distance * nightShortTripFee;
                else
                    if (distance <= 60)
                        fee = TwoWay(distance) * nightMediumTripFee;
                    else
                        fee = TwoWay(distance) * nightLongTripFee;
            }
            return fee;
        }

        private static double TwoWay(double distance)
        {
            return distance * 2;
        }
    }
}
