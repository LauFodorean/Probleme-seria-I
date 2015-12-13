using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram
{
    [TestClass]
    public class AnagramationUnitTest
    {
        [TestMethod]
        public void ThreeLettersWordTestMethod()
        {
            Assert.AreEqual(6, wordAnagramation("abc"));
        }

        [TestMethod]
        public void SixLettersWordTestMethod()
        {
            Assert.AreEqual(720, wordAnagramation("delfin"));
        } 

       public int wordAnagramation(string word)
        {
           int numberOfAnagrams = 1;
           int lettersInWord = word.Length;
           numberOfAnagrams = Factorial(numberOfAnagrams, lettersInWord);
           return numberOfAnagrams;
        }

       private static int Factorial(int numberOfAnagrams, int lettersInWord)
       {
           for (int i = 1; i <= lettersInWord; i++)
               numberOfAnagrams = numberOfAnagrams * i;
           return numberOfAnagrams;
       }
    }
}
