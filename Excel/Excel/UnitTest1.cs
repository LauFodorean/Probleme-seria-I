﻿using System;
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
        public void MultipleOfTwentySixTestMethod()
        {
            Assert.AreEqual("AZ", ColumnNumber(52));
        }


        public string ColumnNumber(int number)
        {
           string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
           string wantedColumndNumber = "";


           while (number > 26)
           {
               int cateDivision = 0;
               int restOfDivision = 0;
               cateDivision = number / 26;
               if (cateDivision > 26)
               {
                   restOfDivision = number % 26;
                   number = cateDivision;

               }
               wantedColumndNumber = alphabet[restOfDivision - 1] + wantedColumndNumber;
           }
          

           wantedColumndNumber = alphabet[number - 1] + wantedColumndNumber;
           //if (number <= 26)
           //    wantedColumndNumber = alphabet[number - 1];
           //else
           //    if (restOfDivision != 0)
           //        wantedColumndNumber = alphabet[cateDivision - 1] + alphabet[restOfDivision - 1];
           //    else
           //        wantedColumndNumber = alphabet[cateDivision - 2] + alphabet[25];
           return wantedColumndNumber;
     

        }
    }
}
