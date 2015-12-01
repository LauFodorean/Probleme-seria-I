﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class RomanNumbersTest
    {
        [TestMethod]
        public void FirstNineNumbersTestMethod()
        {
            string number = CalculateRomanNumbers(1);
            Assert.AreEqual("I", number);
        }

        [TestMethod]
        public void NumberTenTestMethod()
        {
            string number = CalculateRomanNumbers(10);
            Assert.AreEqual("X", number);
        }

        [TestMethod]
        public void NumbersElevenToNineteenTestMethod()
        {
            string number = CalculateRomanNumbers(11);
            Assert.AreEqual("XI", number);
        }

        [TestMethod]
        public void NumberTwentyTestMethod()
        {
            string number = CalculateRomanNumbers(20);
            Assert.AreEqual("XX", number);
        }

        [TestMethod]
        public void NumberTwentyonetoTwentynineTestMethod()
        {
            string number = CalculateRomanNumbers(29);
            Assert.AreEqual("XXIX", number);
        }

        [TestMethod]
        public void NumberThrityTestMethod()
        {
            string number = CalculateRomanNumbers(30);
            Assert.AreEqual("XXX", number);
        }

        [TestMethod]
        public void NumberThrityoneToThritynineTestMethod()
        {
            string number = CalculateRomanNumbers(39);
            Assert.AreEqual("XXXIX", number);
        }

        [TestMethod]
        public void NumberFoutyTestMethod()
        {
            string number = CalculateRomanNumbers(40);
            Assert.AreEqual("XL", number);
        }

        [TestMethod]
        public void NumberFoutyoneToFourtynineTestMethod()
        {
            string number = CalculateRomanNumbers(49);
            Assert.AreEqual("XLIX", number);
        }

        [TestMethod]
        public void NumberFiftyTestMethod()
        {
            string number = CalculateRomanNumbers(50);
            Assert.AreEqual("L", number);
        }

        [TestMethod]
        public void NumberFiftyoneToFiftynineTestMethod()
        {
            string number = CalculateRomanNumbers(59);
            Assert.AreEqual("LIX", number);
        }

        [TestMethod]
        public void NumberSixtyTestMethod()
        {
            string number = CalculateRomanNumbers(60);
            Assert.AreEqual("LX", number);
        }

        [TestMethod]
        public void NumberSixtyoneToSixtynineTestMethod()
        {
            string number = CalculateRomanNumbers(69);
            Assert.AreEqual("LXIX", number);
        }

        [TestMethod]
        public void NumberSeventyTestMethod()
        {
            string number = CalculateRomanNumbers(70);
            Assert.AreEqual("LXX", number);
        }

        [TestMethod]
        public void NumberSeventyoneToSeventynineTestMethod()
        {
            string number = CalculateRomanNumbers(79);
            Assert.AreEqual("LXXIX", number);
        }

        [TestMethod]
        public void NumberEightyTestMethod()
        {
            string number = CalculateRomanNumbers(80);
            Assert.AreEqual("LXXX", number);
        }

        [TestMethod]
        public void NumberEightyoneToEightynineTestMethod()
        {
            string number = CalculateRomanNumbers(89);
            Assert.AreEqual("LXXXIX", number);
        }

        [TestMethod]
        public void NumberNinetyTestMethod()
        {
            string number = CalculateRomanNumbers(90);
            Assert.AreEqual("XC", number);
        }

        [TestMethod]
        public void NumberNinetyoneToNinetynineTestMethod()
        {
            string number = CalculateRomanNumbers(99);
            Assert.AreEqual("XCIX", number);
        }

        [TestMethod]
        public void NumberOnehundredTestMethod()
        {
            string number = CalculateRomanNumbers(100);
            Assert.AreEqual("C", number);
        }

        public string CalculateRomanNumbers(int number)
        {
            string romanNumber = "";
            string[] digitsAndNumbers =  {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "L", "C"};
            int caseswitch = number / 10;
            int remainder = number % 10;
            switch (caseswitch)
            {
                case 0:
                    romanNumber = romanNumber + digitsAndNumbers[number-1];
                    break;

                case 1:
                    if (remainder == 0)
                        romanNumber = digitsAndNumbers[9];
                    else
                        romanNumber = digitsAndNumbers[9] + digitsAndNumbers[remainder-1];
                    break;

                case 2:
                    if (remainder == 0)
                        romanNumber = digitsAndNumbers[9] + digitsAndNumbers[9];
                    else
                        romanNumber = digitsAndNumbers[9] + digitsAndNumbers[9] + digitsAndNumbers[remainder - 1];
                    break;

                case 3:
                    if (remainder == 0)
                        romanNumber = digitsAndNumbers[9] + digitsAndNumbers[9] + digitsAndNumbers[9];
                    else
                        romanNumber = digitsAndNumbers[9] + digitsAndNumbers[9] + digitsAndNumbers[9] + digitsAndNumbers[remainder - 1];
                    break;

                case 4:
                    if (remainder == 0)
                        romanNumber = digitsAndNumbers[9] + digitsAndNumbers[10];
                    else
                        romanNumber = digitsAndNumbers[9] + digitsAndNumbers[10] + digitsAndNumbers[remainder - 1];
                    break;

                case 5:
                    if (remainder == 0)
                        romanNumber = digitsAndNumbers[10];
                    else
                        romanNumber = digitsAndNumbers[10] + digitsAndNumbers[remainder - 1];
                    break;

                case 6:
                    if (remainder == 0)
                        romanNumber = digitsAndNumbers[10] + digitsAndNumbers[9];
                    else
                        romanNumber = digitsAndNumbers[10] + digitsAndNumbers[9] + digitsAndNumbers[remainder - 1];
                    break;

                case 7:
                    if (remainder == 0)
                        romanNumber = digitsAndNumbers[10] + digitsAndNumbers[9] + digitsAndNumbers[9];
                    else
                        romanNumber = digitsAndNumbers[10] + digitsAndNumbers[9] + digitsAndNumbers[9] + digitsAndNumbers[remainder - 1];
                    break;

                case 8:
                    if (remainder == 0) 
                        romanNumber = digitsAndNumbers[10] + digitsAndNumbers[9] + digitsAndNumbers[9] + digitsAndNumbers[9];
                    else
                        romanNumber = digitsAndNumbers[10] + digitsAndNumbers[9] + digitsAndNumbers[9] + digitsAndNumbers[9] + digitsAndNumbers[remainder - 1];
                    break;

                case 9:
                    if (remainder == 0)
                        romanNumber = digitsAndNumbers[9] + digitsAndNumbers[11];
                    else
                        romanNumber = digitsAndNumbers[9] + digitsAndNumbers[11] + digitsAndNumbers[remainder - 1];
                    break;

                case 10:
                    romanNumber = digitsAndNumbers[11];
                    break;
                    
            }

            
            return romanNumber;
        }
    }
}
