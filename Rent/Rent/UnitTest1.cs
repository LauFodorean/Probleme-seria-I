using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rent
{
    [TestClass]
    public class RentTest1
    {
        [TestMethod]
        public void RentDelayOneToTenDays()
        {
            decimal rent = RentCalculation(100, 1);
            Assert.AreEqual(102, rent);
        }

        [TestMethod]
        public void RentDelayElevenToThirtyDays()
        {
            decimal rent = RentCalculation(100, 11);
            Assert.AreEqual(125, rent);
        }

        [TestMethod]
        public void RentDelayThirtyoneToFourtyDays()
        {
            decimal rent = RentCalculation(100, 31);
            Assert.AreEqual(230, rent);
        }

        public decimal RentCalculation(decimal usualRent, int delayInPayments)
        {
            decimal rent = 0;
            if (delayInPayments < 11)
                rent = TwoPercentCalculus(usualRent) * delayInPayments + usualRent;
            else
                if (delayInPayments < 31)
                    rent = (TwoPercentInterest(usualRent) + usualRent) + FivePercentCalculus(usualRent) * (delayInPayments - 10);
                else
                    rent = (TwoPercentInterest(usualRent) + usualRent) + (FivePercentInterest(usualRent) + (TenPercentInterest(usualRent) * (delayInPayments - 30)));
            return rent;
        }

        private static decimal TenPercentInterest(decimal usualRent)
        {
            return (usualRent / 100) * 10;
        }

        private static decimal FivePercentInterest(decimal usualRent)
        {
            return FivePercentCalculus(usualRent) * 20;
        }

        private static decimal TwoPercentInterest(decimal usualRent)
        {
            return TwoPercentCalculus(usualRent) * 10;
        }

        private static decimal FivePercentCalculus(decimal usualRent)
        {
            return (usualRent / 100) * 5;
        }

        private static decimal TwoPercentCalculus(decimal usualRent)
        {
            return (usualRent / 100) * 2;
        }
    }
}
