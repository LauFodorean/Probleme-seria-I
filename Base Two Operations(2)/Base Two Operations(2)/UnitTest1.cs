using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Base_Two_Operations_2_
{
          [TestClass]
    public class BaseTwoOperationsUnitTest
    {
        [TestMethod]
        public void NumberConversionInBinaryBaseTwoTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 1, 1, 1, 0 }, Conversion(14, 2));
        }

        public byte[] Conversion(int number, int givenBaseNumber)
        {

            byte[] convertedNumber = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            int restOfDivision, cateOfDivision;
            for (int i = 7; i >= 0; i--)
            {
                restOfDivision = number % givenBaseNumber;
                cateOfDivision = number / givenBaseNumber;

                if (restOfDivision != 0)
                    convertedNumber[i] = (byte)restOfDivision;

                number = cateOfDivision;
            }

            return convertedNumber;
        }


    }
}
