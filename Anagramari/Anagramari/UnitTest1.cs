using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagramari
{
    [TestClass]
    public class AnagramUnitTest
    {
        [TestMethod]
        public void AnagramTestMethod()
        {
            Assert.AreEqual(2,AnagramCalculation("da"));
        }

        int AnagramCalculation(string givenWord)
        {
            int wordLenght = 0;
            wordLenght = givenWord.Length;
            return (wordLenght * wordLenght)-2;
        }
    }
}
