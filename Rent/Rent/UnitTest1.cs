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
            Assert.AreEqual(125, rent);
        }

        public decimal RentCalculation(decimal usualRent, int delayInPayments)
        {
            decimal rent = 0;
            if (delayInPayments < 11)
                rent = (usualRent / 100) * 2 * delayInPayments + usualRent;
            else
                if (delayInPayments < 31)
                    rent = ((usualRent / 100) * 2 * 10 + usualRent) + ((usualRent / 100) * 5 * (delayInPayments - 10));
                else
                    return 0;
                
                    
            return rent;
        }
    }
}
