using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class RomanNumbersTest
    {
        [TestMethod]
        public void FirstTenNumbersTestMethod()
        {
            string number = CalculateRomanNumbers(1);
            Assert.AreEqual("I", number);
        }

        [TestMethod]
        public void NumbersElevenToTwentyTestMethod()
        {
            string number = CalculateRomanNumbers(11);
            Assert.AreEqual("XI", number);
        }

        public string CalculateRomanNumbers(int number)
        {
            string romanNumber = "";
            string[] digitsAndNumbers =  {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "L", "C"};
            switch (number)
            {
                case 1:
                    romanNumber = romanNumber + digitsAndNumbers[0];
                    break;
                
                //case 2:
                //    int divisionByTen = number / 10;
                //    int remainder = number % 10;
                //    romanNumber[0] = digitsAndNumbers[9];
                //    romanNumber[1] = digitsAndNumbers[remainder];
                    //break;

            }

            
            return romanNumber;
        }
    }
}
