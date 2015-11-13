using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sportiv
{
    [TestClass]
    public class Sportiv
    {
        [TestMethod]
        public void CalculTest()
        {
            Sportiv sp = new Sportiv();
            int repetitii = sp.CalculRepetitii(4);
            Assert.AreEqual(16,repetitii);
        }

        public int CalculRepetitii(int rep)
        {
            return 0;
        }
    }
}
