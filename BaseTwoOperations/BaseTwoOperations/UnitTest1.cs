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

        [TestMethod]
        public void OrTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 1, 1, 1, 1 }, OrMethod(14, 15));
        }

        [TestMethod]
        public void XorTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 0, 0, 1 }, XorMethod(14, 15));
        }

        [TestMethod]
        public void ShiftLeftTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 0, 0, 0 }, ShiftLeftMethod(15, 2 , 6));
        }

        [TestMethod]
        public void ShiftRightTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 0, 0, 1, 1 }, ShiftRightMethod(15, 2, 2));
        }

        [TestMethod]
        public void LessThanTestMethod()
        {
            Assert.AreEqual(true, LessThanMethod(14, 15));
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

        public byte[] OrMethod(int number1, int number2)
        {
            byte[] orNumber = new byte[8];
            byte[] orNumber1 = new byte[8];
            orNumber1 = Conversion(number1, 2);
            byte[] orNumber2 = new byte[8];
            orNumber2 = Conversion(number2, 2);
            bool[] boolOrNumber = new bool[8];
            bool[] boolOrNumber1 = new bool[8];
            bool[] boolOrNumber2 = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                boolOrNumber1[i] = Convert.ToBoolean(orNumber1[i]);
                boolOrNumber2[i] = Convert.ToBoolean(orNumber2[i]);
                boolOrNumber[i] = boolOrNumber1[i] | boolOrNumber2[i];
                orNumber[i] = Convert.ToByte(boolOrNumber[i]);
            }
            return orNumber;
        }

        public byte[] XorMethod(int number1, int number2)
        {
            byte[] xorNumber = new byte[8];
            byte[] xorNumber1 = new byte[8];
            xorNumber1 = Conversion(number1, 2);
            byte[] xorNumber2 = new byte[8];
            xorNumber2 = Conversion(number2, 2);
            bool[] boolXorNumber = new bool[8];
            bool[] boolXorNumber1 = new bool[8];
            bool[] boolXorNumber2 = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                boolXorNumber1[i] = Convert.ToBoolean(xorNumber1[i]);
                boolXorNumber2[i] = Convert.ToBoolean(xorNumber2[i]);
                boolXorNumber[i] = boolXorNumber1[i] ^ boolXorNumber2[i];
                xorNumber[i] = Convert.ToByte(boolXorNumber[i]);
            }
            return xorNumber;
        }

        public byte[] ShiftLeftMethod(int number, int givenBaseNumber, int leftShiftPositions)
        {
            byte[] givenNumber = new byte[8]; // it is the number to be transformed in the given base
            byte[] leftShiftedNumber = new byte[8] {0,0,0,0,0,0,0,0}; // the number with the left shifted positions
            givenNumber = Conversion(number, givenBaseNumber); // the given number converted in the given base
            
            for (int i = 0; i < 8 - leftShiftPositions; i++ )
                leftShiftedNumber[i] = givenNumber[leftShiftPositions + i];
                           
            return leftShiftedNumber; // returns the number with the shifted positions left
        }

        public byte[] ShiftRightMethod(int number, int givenBaseNumber, int rightShiftPositions)
        {
            byte[] givenNumber = new byte[8]; // it is the number to be transformed in the given base
            byte[] rightShiftedNumber = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 }; // the number with the right shifted positions
            givenNumber = Conversion(number, givenBaseNumber); // the given number converted in the given base
            int j = rightShiftPositions;
            int counter = rightShiftPositions - j;
            for (int i = rightShiftPositions; i < 8; i++)
            {
                rightShiftedNumber[i] = givenNumber[counter];
                counter++;
            }
            return rightShiftedNumber; // returns the number with the shifted positions right
        }

        public bool LessThanMethod(int number1, int number2)
        {
            byte[] convertedNumber1 = new byte[8];
            convertedNumber1 = Conversion(number1, 2);
            byte[] convertedNumber2 = new byte[8];
            convertedNumber2 = Conversion(number2, 2);
            bool lessthan = false;
            int i = 0;
            while (lessthan == false & i < 8 )
            {
                if (convertedNumber1[i] < convertedNumber2[i])
                    lessthan = true;
                i++;
            }
            return lessthan;
        }

     }
}
