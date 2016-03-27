using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReplaceCharacterInStringWithString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckIfCharacterIsReplacedByString()
        {
            Assert.AreEqual("gfibgfi", ReplaceCharacterWithString("aba", "a", "gfi"));
        }

        [TestMethod]
        public void CheckIfCharacterIsReplacedByString2()
        {
            Assert.AreEqual("gfigfigfigfi", ReplaceCharacterWithString("aaaa", "a", "gfi"));
        }

        
        public string ReplaceCharacterWithString(string givenString, string characterToReplace, string replacingString)
        {
            int n = 0;
            return ReplaceCharacterWithString(givenString, characterToReplace, replacingString, n);
        }

        public string ReplaceCharacterWithString(string givenString, string characterToReplace, string replacingString, int n)
        {
            if (n == givenString.Length - 1)
                return char.ToString(givenString[n]) == characterToReplace ? replacingString : char.ToString(givenString[n]);
            return (char.ToString(givenString[n]) == characterToReplace ? replacingString : char.ToString(givenString[n])) + ReplaceCharacterWithString(givenString, characterToReplace,replacingString,n + 1);
        }
    }
}
