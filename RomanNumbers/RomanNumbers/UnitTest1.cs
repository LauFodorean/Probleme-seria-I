using System;
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
        public void NumbersElevenToNineteenTestMethod()
        {
            string number = CalculateRomanNumbers(11);
            Assert.AreEqual("XI", number);
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
                    romanNumber = digitsAndNumbers[9] + digitsAndNumbers[remainder-1];
                    break;

            }

            
            return romanNumber;
        }
    }
}
