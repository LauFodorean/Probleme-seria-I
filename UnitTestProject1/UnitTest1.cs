using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Pavement
    {
        [TestMethod]
        public void PavementTest()
        {
            double PavementNumber=PavementCount(305,205,10);
            Assert.AreEqual(651,PavementNumber);
        }

        public double PavementCount(double lenght, double width, int PavementDimension)
        {
            double LenghtPavementCount = lenght / PavementDimension;
            int LenghtPavementNumber = Convert.ToInt32(LenghtPavementCount);
            double LenghtReminder = lenght % PavementDimension;
            if (LenghtReminder > 0)
                LenghtPavementNumber = LenghtPavementNumber + 1;

            double WidthPavementCount = width / PavementDimension;
            int WidthPavementNumber = Convert.ToInt32(WidthPavementCount);
            double WidthReminder = width % PavementDimension;
            if (WidthReminder > 0)
                WidthPavementNumber = WidthPavementNumber + 1;

            return LenghtPavementNumber * WidthPavementNumber;
        }
    }
}
