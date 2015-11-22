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

        public decimal RentCalculation(decimal usualRent, int delayInPayments)
        {
            return 0;
        }
    }
}
