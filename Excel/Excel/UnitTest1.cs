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

        [TestMethod]
        public void FiftyTwoTestMethod()
        {
            Assert.AreEqual("AZ", ColumnNumber(52));
        }

        [TestMethod]
        public void SevenHundredandTwoTestMethod()
        {
            Assert.AreEqual("ZZ", ColumnNumber(702));
        }

        [TestMethod]
        public void SevenHundredandThreeTestMethod()
        {
            Assert.AreEqual("AAA", ColumnNumber(703));
        }


        public string ColumnNumber(int number)
        {
           string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
           string wantedColumndNumber = "";


           while (number > 26)
           {
               int cateDivision = number / 26;
               int restOfDivision = number % 26;
               number = cateDivision;
               if (restOfDivision == 0)
               {
                   wantedColumndNumber = alphabet[25] + wantedColumndNumber;
                   number = cateDivision - 1;
               }
               else
                   wantedColumndNumber = alphabet[restOfDivision - 1] + wantedColumndNumber;
           }
          

           wantedColumndNumber = alphabet[number - 1] + wantedColumndNumber;
           
           return wantedColumndNumber;
     

        }
    }
}
