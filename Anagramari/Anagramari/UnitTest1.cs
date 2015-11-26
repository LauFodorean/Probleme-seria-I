using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagramari
{
    [TestClass]
    public class AnagramUnitTest
    {
        [TestMethod]
        public void AnagramTestMethod1()
        {
            Assert.AreEqual(2,AnagramCalculation("da"));
        }

        [TestMethod]
        public void AnagramTestMethod2()
        {
            Assert.AreEqual(14, AnagramCalculation("masi"));
        }

        int AnagramCalculation(string givenWord)
        {
            int wordLenght = 0;
            wordLenght = givenWord.Length;
            return (wordLenght * wordLenght)-2;
        }
    }
}
