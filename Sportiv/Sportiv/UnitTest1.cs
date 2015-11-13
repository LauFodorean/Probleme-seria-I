using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sportiv
{
    [TestClass]
    public class Athlete
    {
        [TestMethod]
        public void CalcutionTest()
        {
            int repetitions = RepetitionCount(4);
            Assert.AreEqual(16,repetitions);
        }

        public int RepetitionCount(int repetition)
        {
            return repetition * repetition;
        }
    }
}
