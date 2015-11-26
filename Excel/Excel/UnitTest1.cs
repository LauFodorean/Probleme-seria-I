using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel
{
    [TestClass]
    public class ExcelUnitTest
    {
        [TestMethod]
        public void NumberUnderTwentysixTestMethod()
        {
            char number = ColumnNumber(6);
            Assert.AreEqual('F',number);
        }

        [TestMethod]
        public void NumberMultipleOfTwentysixTestMethod()
        {
            char number = ColumnNumber(27);
            Assert.AreEqual('A','A', number);
        }

        public char ColumnNumber(int number)
        {
            char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] columnNumber = new char[1000];
            int cateDivision = 0;
            int restOfDivision = 0;
            if (number <= 26)
                columnNumber[number - 1] = alphabet[number - 1];
            else
            {
                cateDivision = number / 26;
                restOfDivision = number % 26;
                for (int i = 0; i < cateDivision; i++)
                    columnNumber[i] = alphabet[i];
            }
            return columnNumber[number - 1];

        }
    }
}
