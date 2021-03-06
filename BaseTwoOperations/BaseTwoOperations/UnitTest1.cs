﻿using System;
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
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0 }, ShiftLeftMethod(new byte[] { 1, 1, 1, 1 }, 2));
        }

        [TestMethod]
        public void ShiftRightTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1 }, ShiftRightMethod(new byte[] {1, 1, 1, 1}, 2));
        }

        [TestMethod]
        public void LessThanTestMethod()
        {
            Assert.AreEqual(true, LessThanMethod(new byte[] {1,1,1}, new byte[] {1,1,1,0}));
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

        [TestMethod]
        public void ReversedConversionTestMethod()
        {
            Assert.AreEqual(3, ReversedConversionMethod(new byte[] {1, 1 }, 2));
        }

        [TestMethod]
        public void SumResultTestMethod1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1 }, SumResult(new byte[] { 1, 1, 1, 0 }, new byte[] { 1 }));
        }

        [TestMethod]
        public void SumResultTestMethod2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 0, 1 }, SumResult(new byte[] { 1, 1, 1, 1 }, new byte[] { 1, 1, 1, 0 }));
        }

        [TestMethod]
        public void SumResultTestMethod3()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0 }, SumResult(new byte[] { 1, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 }));
        }

        [TestMethod]
        public void DecreaseResultTestMethod3()
        {
            CollectionAssert.AreEqual(new byte[] {0, 1, 1, 1}, DecreaseResult(new byte[] { 1, 0, 0, 0 }, new byte[] { 1 }));
        }

        [TestMethod]
        public void DecreaseResultTestMethod2()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1 }, DecreaseResult(new byte[] { 1, 0, 0, 0 }, new byte[] { 1, 0, 1 }));
        }

        [TestMethod]
        public void DecreaseResultTestMethod1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0 }, DecreaseResult(new byte[] { 1, 1, 1, 1 }, new byte[] { 0, 1, 1, 1 }));
        }

        [TestMethod]
        public void DecreaseResultTestMethod4()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1, 0 }, DecreaseResult(new byte[] { 1, 1, 0, 1 }, new byte[] { 0, 1, 1, 1 }));
        }

        [TestMethod]
        public void MultiplicationTestMethod()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1, 0, 0 }, MultiplicationResult(new byte[] { 1, 0, 1, 0 }, new byte[] { 1, 1, 0 }));
        }

        [TestMethod]
        public void MultiplicationTestMethod2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, MultiplicationResult(new byte[] { 1, 0, 1, 0 }, new byte[] { 1 }));
        }

        [TestMethod]
        public void MultiplicationTestMethod3()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 0, 1, 1, 0 }, MultiplicationResult(new byte[] { 1, 0, 1, 0 }, new byte[] { 1, 1, 1, 1 }));
        }

        [TestMethod]
        public void DivideTestMethod3()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, DivideResult(new byte[] { 1, 1, 1, 1, 0, 0 }, new byte[] { 1, 1, 0 }));
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
            byte[] convertedNumber = new byte[byteLength];
            //Array.Resize<byte>(ref convertedNumber, convertedNumber.Length + byteLength);
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
            byte[] temporaryAndNumber = new byte[positionsToBeMatched];
            //Array.Resize<byte>(ref temporaryAndNumber, temporaryAndNumber.Length + positionsToBeMatched);
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
            byte[] andNumber = new byte[maxLength];
            //Array.Resize<byte>(ref andNumber, andNumber.Length +maxLength);
            for (int i = maxLength - 1; i >= 0; i--)
            {
                andNumber[i] = (GetPositionAt(number1, maxLength - 1 - i) == 1) && (GetPositionAt(number2, maxLength - 1 - i) == 1) ? (byte)1 : (byte)0;
            }
            return andNumber;
        }


        public byte[] OrMethod(byte[] number1, byte[] number2)
        {
            int maxLength = number1.Length > number2.Length ? number1.Length : number2.Length;
            byte[] orNumber = new byte[maxLength];
            //Array.Resize<byte>(ref orNumber, orNumber.Length + maxLength);

            for (int i = maxLength - 1; i >= 0 ; i--)
            {
                orNumber[i] = GetPositionAt(number1, i) + GetPositionAt(number2, i) >= 1 ? (byte)1 : (byte)0;
                              
            }

            return orNumber;
        }
        

        public byte[] XorMethod(byte[] number1, byte[] number2)
        {
            int maxLength = number1.Length > number2.Length ? number1.Length : number2.Length;
            byte[] xorNumber = new byte[maxLength];
            //Array.Resize<byte>(ref xorNumber, xorNumber.Length + maxLength);

            for (int i = maxLength - 1; i >= 0; i--)
            {
                xorNumber[i] = GetPositionAt(number1, maxLength - 1 - i) + GetPositionAt(number2, maxLength - 1 - i) == 1  ? (byte)1 : (byte)0;
            }

            return xorNumber;
        }

        public byte[] ShiftLeftMethod(byte[] number, int leftShiftPositions)
        {
            byte[] leftShiftedNumber = new byte[number.Length];
            //Array.Resize<byte>(ref leftShiftedNumber, leftShiftedNumber.Length + number.Length);
            for (int i = 0; i < leftShiftPositions; i++)
                leftShiftedNumber[i] = number[leftShiftPositions + i];
                           
            return leftShiftedNumber; 
        }

        public byte[] ShiftRightMethod(byte[] number, int rightShiftPositions)
        {
            byte[] rightShiftedNumber = new byte[number.Length];
            //Array.Resize<byte>(ref rightShiftedNumber, rightShiftedNumber.Length + number.Length);
            for (int i = 0; i < number.Length - rightShiftPositions; i++)
            {
                rightShiftedNumber[ i + rightShiftPositions ] = number[i];
            }
            return rightShiftedNumber; 
        }

        public double ReversedConversionMethod(byte[] number, double conversionBaseNumber)
        {
            double convertedNumber = 0;
            double power = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                convertedNumber = convertedNumber + number[i] * Math.Pow(conversionBaseNumber, power);
                power++;
            }
            return convertedNumber;
        }

        public bool LessThanMethod(byte[] number1, byte[] number2)
        {
            double conversionBaseNumber = 2;
            return ReversedConversionMethod(number1, conversionBaseNumber) < ReversedConversionMethod(number2, conversionBaseNumber) ? true : false ;
        }

        public byte[] SumResult( byte[] number1,  byte[] number2)
        {
            int maxLength = (number1.Length >= number2.Length) ? number1.Length : number2.Length;
            byte[] sumResult = new byte[maxLength];
            int givenBaseNumber = 2;
            byte cateOfDivision = 0;
            for (int i = 0; i < maxLength; i++)
            {
               sumResult[sumResult.Length - 1 - i] = (byte)(((GetPositionAt(number1, i) + GetPositionAt(number2, i)) + cateOfDivision) % givenBaseNumber);
               cateOfDivision = (byte)(((GetPositionAt(number1, i) + GetPositionAt(number2, i)) + cateOfDivision) / givenBaseNumber);
            }
            
            if (cateOfDivision > 0)
            {
                Array.Resize<byte>(ref sumResult, sumResult.Length + 1);
                for (int i = 0; i < sumResult.Length - 1; i++)
                    sumResult[sumResult.Length - 1 - i] = sumResult[sumResult.Length - 1 - i - 1];
                sumResult[0] = cateOfDivision;
            }
            return sumResult;
        }

        public byte[] DecreaseResult(byte[] number1, byte[] number2)
        {
            byte[] decResult = new byte[number1.Length];
            int givenBaseNumber = 2;
            byte reminder = 0;
            
            for (int i = 0; i < decResult.Length;  i++)
            {
                if (GetPositionAt(number1, i) - reminder < GetPositionAt(number2, i))
                {
                    decResult[decResult.Length - 1 - i] = (byte)((GetPositionAt(number1, i) - reminder + givenBaseNumber) - GetPositionAt(number2, i));
                    reminder = 1;
                }
                else
                {
                    decResult[decResult.Length - 1 - i] = (byte)((GetPositionAt(number1, i) - reminder) - GetPositionAt(number2, i));
                    reminder = 0;
                }

            }
            
            return decResult;
            
        }

        public byte[] MultiplicationResult(byte[] number1, byte[] number2)
        {
            byte[] multiplicationResult = new byte[number1.Length+number2.Length-1];
            byte[] multiplicationRow = new byte[number1.Length];
            int j = 0;
            int counter = 0;
            while (j < number2.Length)
            {
                for (int i = 0; i < number1.Length; i++)
                    multiplicationRow[multiplicationRow.Length - 1 - i ] = (byte)(GetPositionAt(number2, j) * GetPositionAt(number1, i));
                Array.Resize<byte>(ref multiplicationRow, multiplicationRow.Length + counter);
                multiplicationResult = SumResult(multiplicationRow, multiplicationResult);
                Array.Resize<byte>(ref multiplicationRow, multiplicationRow.Length - counter);
                counter = counter + 1;
                j++;
            }
            return multiplicationResult;
        }
        
        public byte[] DivideResult(byte[] number1, byte[] number2)
        {
            int counter = 0, givenBaseNumber = 2;
            for (byte[] i = number1; ReversedConversionMethod(i, givenBaseNumber) >= ReversedConversionMethod(number2, givenBaseNumber); i = DecreaseResult(i, number2))
            {
                counter = counter + 1;
            }
            return Conversion(counter, givenBaseNumber);            
        }

     }
}
