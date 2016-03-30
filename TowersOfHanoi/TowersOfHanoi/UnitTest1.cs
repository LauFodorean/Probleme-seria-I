using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TowersOfHanoi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int numberOfDisks = 3;
            Assert.AreEqual(" Muta D1 de la turnul 1 la turnul 2; Muta D2 de la turnul 1 la turnul 3; Muta D1 de la turnul 2 la turnul 3; Muta D3 de la turnul 1 la turnul 2; Muta D1 de la turnul 3 la turnul 1; Muta D2 de la turnul 3 la turnul 2; Muta D1 de la turnul 1 la turnul 2;",
                              SolveTowersOfHanoi(numberOfDisks,1,2));
        }

        public string SolveTowersOfHanoi(int numberOfDisks, int a, int b)
        {
            a = 1; b = 2;
            return HanoiTowers(numberOfDisks, a, b );
        }

        public string HanoiTowers(int numberOfDisks, int a, int b)
        {
            string text = "";
            int c = 6 - a - b;

            if (numberOfDisks == 1)
                return text = MutaDisc(numberOfDisks, a, b);
            if (numberOfDisks>1)
                return text = HanoiTowers(numberOfDisks - 1, a, c) + MutaDisc(numberOfDisks, a, b) + HanoiTowers(numberOfDisks - 1, c, b);
                        
            return text;                       
        }

        public string MutaDisc(int numberOfDisks, int a, int b)
        {
            return " Muta D" + numberOfDisks + " de la turnul " + a + " la turnul " + b + ";";
        }
    }
}
