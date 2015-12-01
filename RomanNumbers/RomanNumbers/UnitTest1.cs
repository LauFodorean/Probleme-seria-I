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

        public string CalculateRomanNumbers(int number)
        {
            string[] romanNumber = new string[20];
            string[] digitsAndNumbers =  {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "L", "C"};
            switch (number)
            {
                case 1:
                    romanNumber[0] = digitsAndNumbers[0];
                    break;
            }

            
            return romanNumber[0];
        }
    }
}
