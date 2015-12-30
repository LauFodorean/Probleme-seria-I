using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseTwoOperations
{
    [TestClass]
    public class BaseTwoOperationsUnitTest
    {
        [TestMethod]
        public void NumberConversionInBinaryTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 1, 1, 1, 0 }, Conversion(14, 2));
        }

        [TestMethod]
        public void NotTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1, 0, 0, 0, 1 }, NotMethod(14));
        }

        
        public byte[] Conversion(int number, int givenBaseNumber)
        {
            
            byte[] convertedNumber = new byte[8] {0,0,0,0,0,0,0,0};
            int restOfDivision, cateOfDivision;
            for (int i = 7; i >= 0; i--)
            {
                restOfDivision = number % givenBaseNumber;
                cateOfDivision = number / givenBaseNumber;

                if (restOfDivision != 0)
                    convertedNumber[i] = (byte)1;

                number = cateOfDivision;
            }
                
            return convertedNumber;
        }

        public byte[] NotMethod(int number)
        {
            byte[] notNumber = new byte[8];
            notNumber = Conversion(number, 2);
            bool[] boolNotNumber = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                boolNotNumber[i] = Convert.ToBoolean(notNumber[i]);
                boolNotNumber[i] = !boolNotNumber[i];
                notNumber[i] = Convert.ToByte(boolNotNumber[i]);
            }
            return notNumber;
        }

     }
}
