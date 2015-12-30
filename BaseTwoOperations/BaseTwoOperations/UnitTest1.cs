using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseTwoOperations
{
    [TestClass]
    public class BaseTwoOperationsUnitTest
    {
        [TestMethod]
        public void NumberConversionInBinary()
        {
            Assert.AreEqual(0, Conversion(14));
        }


        public byte Conversion(int number)
        {
            
            byte[] convertedNumber = new byte[8] {0,0,0,0,0,0,0,0};
            int restOfDivision, cateOfDivision;
            for (int i = 7; i >= 0; i--)
            {
                restOfDivision = number % 2;
                cateOfDivision = number / 2;

                if (restOfDivision != 0)
                    convertedNumber[i] = 1;

                number = cateOfDivision;
            }
                
                return convertedNumber[3];
        }
    }
}
