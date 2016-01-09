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
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 0 }, Conversion(14, 2));
        }

        [TestMethod]
        public void Number255ConversionInBinaryBaseTwoTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 }, Conversion(255, 2));
        }

        [TestMethod]
        public void Number255ConversionInBinaryBaseFourTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 3, 3, 3 }, Conversion(255, 4));
        }

        [TestMethod]
        public void NotTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1 }, NotMethod(new byte[] { 1, 1, 1, 0}));
        }

        [TestMethod]
        public void AndTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 0 }, AndMethod(new byte[] { 1, 1, 1, 1 }, new byte[] { 1, 1, 1, 0 }));
        }

        [TestMethod]
        public void AndForDifferentLenghtNumbersTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 0 }, AndMethod(new byte[] { 1, 1, 1, 1 }, new byte[] { 1, 0 }));
        }

        [TestMethod]
        public void OrTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1 }, OrMethod(new byte[] { 1, 1, 1, 1 }, new byte[] { 1, 1, 1, 0 }));
        }

        [TestMethod]
        public void XorTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, XorMethod(new byte[] { 1, 1, 1, 1 }, new byte[] { 1, 0, 1 }));
        }

        [TestMethod]
        public void Xor2TestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1 }, XorMethod(new byte[] { 1, 1, 1, 0 }, new byte[] { 1, 1, 1 }));
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

        [TestMethod]
        public void SetArrayLengthTestMethod()
        {
            Assert.AreEqual(5, SetArrayLength(25, 2));
        }

        [TestMethod]
        public void MatchPositionsTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1 }, MatchPositions(new byte[] { 1, 1 }, 4));
        }

        [TestMethod]
        public void GetPositionAtTestMethod()
        {
            Assert.AreEqual(0, GetPositionAt(new byte[] { 0, 1, 1 }, 2));
        }

        public byte GetPositionAt(byte[] number, int position)
        {
            if (position > number.Length - 1) 
                return (byte)0;
            else
                return number[number.Length - 1 - position];
        }

        public int SetArrayLength(int number, int givenBaseNumber)
        {
            int cateOfDivision;
            int numberOfDivisions = 0;
            do
            {
                cateOfDivision = number / givenBaseNumber;
                number = cateOfDivision;
                numberOfDivisions += 1;
            }
            while (cateOfDivision != 0);
            return numberOfDivisions;
        }

        public byte[] Conversion(int number, int givenBaseNumber)
        {
            int restOfDivision, cateOfDivision;
            int byteLength = SetArrayLength(number,givenBaseNumber);
            byte[] convertedNumber = new byte[] {};
            Array.Resize<byte>(ref convertedNumber, convertedNumber.Length + byteLength);
            for (int i = convertedNumber.Length - 1; i >= 0; i--)
            {
                restOfDivision = number % givenBaseNumber;
                cateOfDivision = number / givenBaseNumber;

                if (restOfDivision != 0)
                    convertedNumber[i] = (byte)restOfDivision;

                number = cateOfDivision;
            }
            
            return convertedNumber;
        }

        public byte[] NotMethod(byte[] number)
        {
            
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = (number[i] == 0) ? (byte)1 : (byte)0;
                //if (number[i] == 0)
                //    number[i] = 1;
                //else
                //    number[i] = 0;
            }
            return number;
        }

        public byte[] MatchPositions(byte[] number, int positionsToBeMatched)
        {
            byte[] temporaryAndNumber = new byte[] {};
            Array.Resize<byte>(ref temporaryAndNumber, temporaryAndNumber.Length + positionsToBeMatched);
            int j = 1;
            for (int i = temporaryAndNumber.Length - 1; i >= temporaryAndNumber.Length - number.Length; i--)
                {
                    temporaryAndNumber[i] = number[number.Length - j];
                    j++;
                }
            return temporaryAndNumber;

        }
        
        public byte[] AndMethod(byte[] number1, byte[] number2)
        {
            int maxLength = number1.Length > number2.Length ? number1.Length : number2.Length;
            byte[] andNumber = new byte[] { };
            Array.Resize<byte>(ref andNumber, andNumber.Length +maxLength);
            for (int i = maxLength - 1; i >= 0; i--)
            {
                andNumber[i] = (GetPositionAt(number1, maxLength - 1 - i) == 1) && (GetPositionAt(number2, maxLength - 1 - i) == 1) ? (byte)1 : (byte)0;
            }
            return andNumber;
        }


        public byte[] OrMethod(byte[] number1, byte[] number2)
        {
            int maxLength = number1.Length > number2.Length ? number1.Length : number2.Length;
            byte[] orNumber = new byte[] { };
            Array.Resize<byte>(ref orNumber, orNumber.Length + maxLength);

            for (int i = maxLength - 1; i >= 0 ; i--)
            {
                orNumber[i] = GetPositionAt(number1, i) + GetPositionAt(number2, i) >= 1 ? (byte)1 : (byte)0;
                              
            }

            return orNumber;
        }
        

        public byte[] XorMethod(byte[] number1, byte[] number2)
        {
            int maxLength = number1.Length > number2.Length ? number1.Length : number2.Length;
            byte[] xorNumber = new byte[] { };
            Array.Resize<byte>(ref xorNumber, xorNumber.Length + maxLength);

            for (int i = maxLength - 1; i >= 0; i--)
            {
                xorNumber[i] = GetPositionAt(number1, maxLength - 1 - i) + GetPositionAt(number2, maxLength - 1 - i) == 1  ? (byte)1 : (byte)0;
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
