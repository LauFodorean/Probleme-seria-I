using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LunchMeal
{
    [TestClass]
    public class LunchUnitTest
    {
        [TestMethod]
        public void NumberOfDaysTestMethod()
        {
            int numberOfDays = NumberOfDaysCalculation(4, 6);
            Assert.AreEqual(12, numberOfDays);
        }

        public int NumberOfDaysCalculation(int friendsVisit, int myVisit)
        {
            int numberOfDays = 0;
            
            do
                numberOfDays = numberOfDays + 4;
            while (numberOfDays % 6 != 0);
            
            return numberOfDays;
        }
    }
}
