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
            Assert.AreEqual("E",ColumnNumber(5));
        }

        [TestMethod]
        public void NumberThirtyTwoTestMethod()
        {
            Assert.AreEqual("AF", ColumnNumber(32));
        }


        public string ColumnNumber(int number)
        {
           string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
           string wantedColumndNumber = "";
           int cateDivision = number / 26;
           int restOfDivision = number % 26;
           if (number <= 26)
               wantedColumndNumber = alphabet[number - 1];
           else
               wantedColumndNumber = alphabet[cateDivision - 1] + alphabet[restOfDivision - 1];
           return wantedColumndNumber;
     

        }
    }
}
