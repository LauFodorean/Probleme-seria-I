using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditBancar
{
    [TestClass]
    public class Credit
    {
        [TestMethod]
        public void Rata()
        {
            Credit obj = new Credit();
            double rata = obj.CalculRata(40000.00, 7.57);
            Assert.AreEqual(179.28,rata);

        }

        public double CalculRata(double suma, double procent)
        {
            return 0.00;
        }
    }
}
