using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculatorWhenWeHaveOnlyOnePositionInString()
        {
            Assert.AreEqual(1d, Calculator("1"));
        }

        [TestMethod]
        public void TestCalculatorWhenWeHaveOnlyOneOperationAndTwoNumbers()
        {
            Assert.AreEqual(2d, Calculator("+ 1 1"));
        }

        [TestMethod]
        public void TestCalculatorWhenWeHaveFourNumbersAndThreeOperations()
        {
            Assert.AreEqual(4d, Calculator("+ + 1 1 + 1 1"));
        }

        public double Calculator(string givenstring)
        {
            string[] stringArray = givenstring.Split(' ');
            int position = 0;
            double result = 0;
            result = result + Calculate(stringArray, ref position);
            return result;
        }

        public double Calculate(string[] givenStringArray, ref int position)
        {
            double result;

            if (Double.TryParse(givenStringArray[position], out result))
                return result;
            else
            {
                position++;
                double firstValue = double.Parse(givenStringArray[position]);
                result = firstValue + Calculate(givenStringArray, ref position);
                return result;
            }
        }
        
        

        //public string RemoveBlancSpacesFromString(string givenString)
        //{
        //    string newString = "";
        //    for (int i = 0; i < givenString.Length; i++)
        //        if (givenString[i] != ' ')
        //            newString = newString + givenString[i];
        //    return newString;
        //}
    }
}
