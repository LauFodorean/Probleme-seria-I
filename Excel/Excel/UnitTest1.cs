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
            Assert.AreEqual("F",ColumnNumber(5));
        }

        [TestMethod]
        public void NumberSeventyEightTestMethod()
        {
            Assert.AreEqual("BZ", ColumnNumber(78));
        }
        

       

        public string ColumnNumber(int number)
        {
           string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
           string[,] matrix1 = new string [26 , 26];
           string[,] matrix2;

           string wantedColumndNumber = "";
           int cateDivision = 0;
           int restOfDivision = 0;
           if (number < 26)
               wantedColumndNumber = wantedColumndNumber + alphabet[number];
           else
           {
               cateDivision = number / 26;
               restOfDivision = number % 26;
               int numberOfRows = cateDivision;
               if (restOfDivision != 0)
                   numberOfRows = cateDivision + 1;
               for (int i = 0; i < numberOfRows; i++)
                   for (int j = 0; j < 26; j++)
                       matrix1[i, j] = alphabet[i] + alphabet[j];
               wantedColumndNumber = matrix1[cateDivision, restOfDivision];
               }


            return wantedColumndNumber;

        }
    }
}
