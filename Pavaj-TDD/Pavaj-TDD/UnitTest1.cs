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
                return 0;
            else
                return 0;
        }


    }
}
