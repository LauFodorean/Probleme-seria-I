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
            double OriginalSide = CalculusOfSide(6, 5);
            Assert.AreEqual(1, OriginalSide);
        }

        [TestMethod]
        public void WantedSide()
        {
            double OriginalSide = CalculusOfSide(770000, 230);
            Assert.AreEqual(770, OriginalSide);
        }

        public int CalculusOfSide(int TotalArea, int KnownLenght)
        {
            int a = 0, Result = 0;
            do
            {
                a = a + 1;
                Result = (TotalArea / a) - a;
            }
            while (Result != KnownLenght);
            return a;
        }
    }
}

