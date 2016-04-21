using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

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

        //[TestMethod]
        //public void TestCalculatorWhenWeHaveOnlyOnePositionInString()
        //{
        //    Assert.AreEqual(1m, PrefixedCalculator("1"));
        //}

        //[TestMethod]
        //public void TestCalculatorWhenWeHaveOnlyOneOperationAndTwoNumbers()
        //{
        //    Assert.AreEqual(2m, PrefixedCalculator("+ 1 1"));
        //}

        //[TestMethod]
        //public void TestCalculatorWhenWeHaveFourNumbersAndThreeOperations()
        //{
        //    Assert.AreEqual(4m, PrefixedCalculator("+ + 1 1 + 1 1"));
        //}

        //[TestMethod]
        //public void TestCalculatorWhenWeHaveFourNumbersAndThreeOperations2()
        //{
        //    Assert.AreEqual(10m, PrefixedCalculator("+ + 1 2 + 3 4"));
        //}

        [TestMethod]
        public void TestDoOperationPlus()
        {
            Assert.AreEqual(3m, DoOperation("+", "1", "2"));
        }

        [TestMethod]
        public void TestDoOperationMinus()
        {
            Assert.AreEqual(1m, DoOperation("-", "2", "1"));
        }

        [TestMethod]
        public void TestDoOperationMultiplicate()
        {
            Assert.AreEqual(4m, DoOperation("*", "2", "2"));
        }

        [TestMethod]
        public void TestDoOperationDivide()
        {
            Assert.AreEqual(2m, DoOperation("/", "4", "2"));
        }

        //[TestMethod]
        //public void TestPrefixedCalculatorForOneAndTwoMultiplication()
        //{
        //    Assert.AreEqual(2m, PrefixedCalculator("* 1 2"));
        //}

        //[TestMethod]
        //public void TestPrefixedCalculatorForFourNumbersOneMutiplicationAnTwoPluses()
        //{
        //    Assert.AreEqual(6m, PrefixedCalculator("* + 1 2 + 1 1"));
        //}

        //[TestMethod]
        //public void TestPrefixedCalculatorLastExample()
        //{
        //    decimal result = 0m;
        //    result = ((56m + 45m) * 46m) / 3m + (1m - 0.25m);
        //    Assert.AreEqual(result, PrefixedCalculator("+ / * + 56 45 46 3 - 1 0.25"));
        //}

        public double Calculator(string givenstring)
        {
            string[] stringArray = givenstring.Split(' ');
            int position = 0;
            double result = 0;
            result = Calculate(stringArray, ref position);
            return result;
        }

        //public decimal PrefixedCalculator(string givenstring)
        //{
        //    string[] stringArray = givenstring.Split(' ');
        //    decimal result = 0m;
        //    int counter = 0;
        //    return result = PrefixedCalculator(ref stringArray,ref counter);
        //}

        public double Calculate(string[] givenStringArray, ref int position)
        {
            double result = 0d;
            if (Double.TryParse(givenStringArray[position], out result))
            {
                return result;
            }
           
            //else
            //{
                position++;
                double firstValue = double.Parse(givenStringArray[position]);
                result = firstValue + Calculate(givenStringArray, ref position);
                return result;
            //}
        }
            //}

            //position++;
            //return result + Calculate(givenStringArray, ref position, result);          
        

        //public decimal PrefixedCalculator(ref string[] givenStringArray, ref int counter)
        //{
        //    decimal newNumber = 0m;
        //    if (givenStringArray.Length - 1 == 0 & counter == 0 )
        //        return decimal.Parse(givenStringArray[0]);
        //    else
        //    {
        //        counter = 1;
        //        int i = givenStringArray.Length - 3;
                
        //        while (i >= 0)
        //        {
        //            string stringOperator = givenStringArray[i];
        //            if (stringOperator == "+" || stringOperator == "-" || stringOperator == "*" || stringOperator == "/")
        //            {
        //                newNumber = DoOperation(givenStringArray[i], givenStringArray[i + 1], givenStringArray[i + 2]);
        //                ArrayList list = new ArrayList(givenStringArray);
        //                list.RemoveRange(i + 1, 2);
        //                list.CopyTo(givenStringArray);
        //                givenStringArray[i] = System.Convert.ToString(newNumber);
        //                Array.Resize(ref givenStringArray, givenStringArray.Length - 2);
        //                i = givenStringArray.Length - 2;
        //                i--;
                        
        //            }
        //            else
        //                i--;
                
        //        }

        //        return newNumber;
                
        //    }
        //}

        public decimal DoOperation(string operatorSign, string firstString, string secondString)
        {
            decimal newNumber = 0m;
            switch (operatorSign)
            {
                case "+" :
                    newNumber = decimal.Parse(firstString) + decimal.Parse(secondString);
                    break;
                case "-" :
                    newNumber = decimal.Parse(firstString) - decimal.Parse(secondString);
                    break;
                case "*" :
                    newNumber = decimal.Parse(firstString) * decimal.Parse(secondString);
                    break;
                case "/" :
                newNumber = decimal.Parse(firstString) / decimal.Parse(secondString);
                break;
            }
            return newNumber;
        }
    }
}

