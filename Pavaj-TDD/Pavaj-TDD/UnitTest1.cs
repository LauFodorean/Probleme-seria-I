using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pavaj_TDD
{
    [TestClass]
    public class Calcule
    {
        [TestMethod]
        public void PavelePe_o_Directie()
        {
            Calcule obj = new Calcule();
            int rezultat = obj.NrDirectie(30, 10);
            Assert.AreEqual(3, rezultat);
        }

        public int NrDirectie(int dim1, int dim2)
        {
            int numar;
            if ((dim1 % dim2) > 0)
                return numar = (dim1 / dim2) + 1;
            else
                return numar = dim1 / dim2;
        }

        [TestMethod]
        public void TotalPavele()
        {
            Calcule obj = new Calcule();
            int rezultat = obj.NrPavele(30, 20);
            Assert.AreEqual(600, rezultat);
        }

        public int NrPavele(int nr1, int nr2)
        {
            return 0;
        }




    }
}
