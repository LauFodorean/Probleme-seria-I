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

        [TestMethod]
        public void DimParchet()
        {
            Parchet obj = new Parchet();
            double Supraf = obj.CalcSuprP(1.00, 0.25);
            Assert.AreEqual(1.00 * 0.25, Supraf);
        }

        public double CalcSuprP(double lungime, double latime)
        {
            return lungime*latime;
        }

        [TestMethod]
        public void NumarBucati()
        {
            Parchet obj = new Parchet();
            double BucatiParchet = obj.BucParchet(5.45*7.55, 0.25);
            Assert.AreEqual(190, BucatiParchet);
        }

        public int BucParchet(double SuprCam, double SuprBucP)
        {
            double BucatiD = SuprCam / SuprBucP;
            int BucatiI = 0;
            double BucatiD2;
            int BucatiI2 = 0;
            int nr;
            BucatiI = Convert.ToInt32(BucatiD);
            double dif,dif2;
            dif = BucatiD-BucatiI;
            if (dif > 0)
            {
                nr = (BucatiI + 1);
                BucatiD2 = nr*1.15;
                BucatiI2 = Convert.ToInt32(BucatiD2);
                dif2 = BucatiD2 - BucatiI2;
                if (dif > 0)
                    nr = BucatiI2 + 1;
                else
                    nr = BucatiI2;
            }
            else
            {
                nr = BucatiI;
                BucatiD2 = nr * 1.15;
                BucatiI2 = Convert.ToInt32(BucatiD2);
                dif2 = BucatiD2 - BucatiI2;
                if (dif > 0)
                    nr = BucatiI2 + 1;
                else
                    nr = BucatiI2;
            }
            
            return nr;
        }

     }
}
