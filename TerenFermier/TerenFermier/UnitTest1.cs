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

        public int CalculusOfSide(int TotalArea, int KnownLenght)
        {
            int a = 0, Result = 0;
            do
            {
                a = a + 1;
                Result = TotalArea / a - a;
            }
            while (Result != 5);
            return a;
        }
    }
}

