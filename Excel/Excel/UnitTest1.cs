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

        public string ColumnNumber(int number)
        {
           string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
           string wantedColumndNumber = "";
            
           wantedColumndNumber = alphabet[number - 1];
           
           return wantedColumndNumber;

        }
    }
}
