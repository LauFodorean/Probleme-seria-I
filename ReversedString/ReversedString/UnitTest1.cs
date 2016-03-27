using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReversedString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckReversedSring()
        {
            Assert.AreEqual("gfedcba", ReverseString("abcdefg"));
        }

        public string ReverseString(string givenString) 
        {
            int n = givenString.Length;
            return ReversedString (givenString, n);
        }

        public string ReversedString (string givenString, int n)
        {
            if (n == 0)
                return "";
            return givenString[n-1] + ReversedString(givenString, n-1);
        }

    }
}
