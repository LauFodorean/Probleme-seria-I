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
            String result = FizzBuzzMethod(9, 3, 5);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void TestBuzz()
        {
            String result = FizzBuzzMethod(10, 3, 5);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void TestFizzBuzz()
        {
            String result = FizzBuzzMethod(15, 3, 5);
            Assert.AreEqual("FizzBuzz", result);
        }

        public string FizzBuzzMethod(int givenNumber, int firstDivisor, int secondDivisor)
        {
            String actualResult=" ";
            double firstReminder = givenNumber % firstDivisor;
            double secondReminder = givenNumber % secondDivisor;
            if (firstReminder == 0 && secondReminder == 0)
                actualResult = "FizzBuzz";
            else
                if (firstReminder == 0 && secondReminder != 0)
                    actualResult = "Fizz";
                else
                    actualResult = "Buzz";

            return actualResult;
        }
    }
}
