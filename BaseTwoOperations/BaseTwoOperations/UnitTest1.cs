using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseTwoOperations
{
    [TestClass]
    public class BaseTwoOperationsUnitTest
    {
        [TestMethod]
        public void NumberConversionInBinaryBaseTwoTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 1, 1, 1, 0 }, Conversion(14, 2));
        }

        [TestMethod]
        public void Number255ConversionInBinaryBaseTwoTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 }, Conversion(255, 2));
        }

        [TestMethod]
        public void Number255ConversionInBinaryBaseFourTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 3, 3, 3, 3 }, Conversion(255, 4));
        }

        [TestMethod]
        public void NotTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1, 0, 0, 0, 1 }, NotMethod(14));
        }

        [TestMethod]
        public void AndTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 1, 1, 1, 0 }, AndMethod(14,15));
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
                    convertedNumber[i] = (byte)restOfDivision;

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

        public byte[] AndMethod(int number1, int number2)
        {
            byte[] andNumber = new byte[8];
            byte[] andNumber1 = new byte[8];
            andNumber1 = Conversion(number1, 2);
            byte[] andNumber2 = new byte[8];
            andNumber2 = Conversion(number2, 2);
            bool[] boolAndNumber = new bool[8];
            bool[] boolAndNumber1 = new bool[8];
            bool[] boolAndNumber2 = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                boolAndNumber1[i] = Convert.ToBoolean(andNumber1[i]);
                boolAndNumber2[i] = Convert.ToBoolean(andNumber2[i]);
                boolAndNumber[i] = boolAndNumber1[i]&boolAndNumber2[i];
                andNumber[i] = Convert.ToByte(boolAndNumber[i]);
            }
            return andNumber;
        }

     }
}
