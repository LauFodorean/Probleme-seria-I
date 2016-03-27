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
            int numberOfDisks = 2;
            Assert.AreEqual(" Move disk 1 from A to C, Move disk 2 from A to B, Move disk 1 from C to B, Move disk 3 from A to C, Move disk 1 from B to A, Move disk 2 from B to C, Move disk 1 from A to C",
                              SolveTowersOfHanoi(numberOfDisks));
        }

        public string SolveTowersOfHanoi(int numberOfDisks)
        {
            return Towers(numberOfDisks, 'S','D','A');
        }

        public string Towers(int numberOfDisks, char sourceTower, char destinationTower, char auxiliaryTower)
        {
            if (numberOfDisks == 0) Console.WriteLine ("");
                        
            Towers(numberOfDisks - 1, sourceTower, auxiliaryTower, destinationTower);
            string text = " Move disk " + numberOfDisks + " from " + sourceTower + " to " + destinationTower; 
            
            Towers(numberOfDisks - 1, auxiliaryTower, sourceTower, auxiliaryTower);

            return text;
            //return " Move disk " + numberOfDisks + " from " + sourceTower + " to " + destinationTower; 
        }
    }
}
