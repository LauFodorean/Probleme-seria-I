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
            decimal rata = obj.CalculRata(40000.00m,20.00m,7.57m);
            Assert.AreEqual(179.28,rata);

        }

        public decimal CalculRata(decimal suma,decimal pd, decimal procent)
        {
            decimal rata;    
            rata = suma / (pd * 12) * (1 + (procent / 100));
            return rata;
            
        }
    }
}
