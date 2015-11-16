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

        public string FizzBuzzMethod(int GivenNumber, int FirstDivisor, int SecondDivisor)
        {
            String ActualResult=" ";
            double FirstReminder = GivenNumber % FirstDivisor;
            double SecondReminder = GivenNumber % SecondDivisor;
            if (FirstReminder == 0 && SecondReminder == 0)
                ActualResult = "FizzBuzz";
            else
                if (FirstReminder == 0 && SecondReminder != 0)
                    ActualResult = "Fizz";
                else
                    if (FirstReminder != 0 && SecondReminder == 0)
                    ActualResult = "Buzz";

            return ActualResult;
        }
    }
}
