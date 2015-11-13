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
            decimal rata = CalculRata(40000.00m,20.00m,7.57m);
            Assert.AreEqual(40000.00m / (20.00m *12)*(1+(7.57m/100)), rata);

        }

        public decimal CalculRata(decimal suma,decimal pd, decimal procent)
        {
            //decimal rata;    
            //rata = suma / (pd * 12) * (1 + (procent / 100));
            //return rata;
            return 0;
            
        }
    }
}
