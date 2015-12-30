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

        //[TestMethod]
        //public void NotTestMethod()
        //{
        //    Assert.AreEqual(false, NotMethod(14,13));
        //}


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

     }
}
