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
            return ReversedString (givenString, ref n);
        }

        public string ReversedString (string givenString, ref int n)
        {
            string reversedString = "";
            string charFromInitialString = "";
            if (n > 0)
            {
                charFromInitialString = ReversedString(givenString,n-1);
                
            }
            return reversedString + charFromInitialString;
        }

    }
}
