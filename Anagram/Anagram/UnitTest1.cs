using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram
{
    [TestClass]
    public class AnagramationUnitTest
    {
        [TestMethod]
        public void FirstTestMethod()
        {
            string variant = wordAnagramation("mare");
            Assert.AreEqual("amre", variant);
        }

        [TestMethod]
        public void PivotTestMethod()
        {
            string variant = wordAnagramation("mare");
            Assert.AreEqual("amre", variant);
        }

        public string wordAnagramation(string word)
        {
            string[] anagramation;
            char letter = word[1];
            string anagram;
            string pivot;
            //anagram = char.ToString(word[1]);
            //anagram = anagram + char.ToString(word[0]);
            //anagram = anagram + char.ToString(word[2]);
            //anagram = anagram + char.ToString(word[3]);
            //return anagram;
            //for (int i = 0; i < word.Length; i++)
                int i = 0;
                anagram = char.ToString(word[i]);
            for (int j = 1; j < word.Length; j++)
                pivot = char.ToString(word[j]);
                char.ToString(word[j]) = char.ToString(word[j + 1];
                word[j + 1] = pivot;
                anagram = anagram + char.ToString(word[j]) + char.ToString(word[j+1]);
            return pivot;

        }
    }
}
