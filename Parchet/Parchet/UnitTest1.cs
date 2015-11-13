using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parchet
{
    [TestClass]
    public class Parchet
    {
        [TestMethod]
        public void SuprafataCamera()
        {
            Parchet obj = new Parchet();
            double SuprafCamera = obj.CalcSuprCam(5.45, 7.55);
            Assert.AreEqual(5.45 * 7.55, SuprafCamera);
        }

        public double CalcSuprCam(double lungime, double latime)
        {
            return lungime*latime;
        }
    }
}
