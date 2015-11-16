using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmerField
{
    [TestClass]
    public class Farmer
    {
        [TestMethod]
        public void Side()
        {
            double OriginalSide = CalculusOfSide(2, 1);
            Assert.AreEqual(1, OriginalSide);
        }

        public int CalculusOfSide(int TotalArea, int KnownLenght)
        {
            return 0;
        }
    }
}

