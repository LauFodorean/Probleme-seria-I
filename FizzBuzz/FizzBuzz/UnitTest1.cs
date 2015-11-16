using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class NumberToBeTested
    {
        [TestMethod]
        public void TestFizz()
        {
            String result = FizzBuzzMethod(15, 3, 5);
            Assert.AreEqual("Fizz", result);
        }

        public string FizzBuzzMethod(int GivenNumber, int FirstDivisor, int SecondDivisor)
        {
            return "Buzz";
        }
    }
}
