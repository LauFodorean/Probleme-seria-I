using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculator()
        {
            Assert.AreEqual("3", Calculator(" + 1 + 1 1 "));
        }

        [TestMethod]
        public void TestCalculator2()
        {
            Assert.AreEqual("8", Calculator(" + + + 3 2 1 + 1 1 "));
        }

        [TestMethod]
        public void TestRemoveBlancSpacesFromString()
        {
            Assert.AreEqual("11", RemoveBlancSpacesFromString("1 1"));
        }

        public string Calculator(string givenstring)
        {
            string text = "";
            int firstPossiblePositionForOperator = givenstring.Length-3;
            return text + ReturnModifiedString(givenstring, firstPossiblePositionForOperator ,text);
        }
        
        public string ReturnModifiedString(string givenString, int firstPossiblePositionForOperator, string text)
        {
            string modifiedString = "";
            if (givenString.Length < 3) return text;
                            
            modifiedString = RemoveBlancSpacesFromString(givenString);
            string randomOperatorInString = "";
            double result;
            string plus = "+";
            string minus = "-";
            string multiply = "*";
            string divide = "/";
                
            int i = 3;

            string stringResult = "";
            randomOperatorInString = modifiedString[modifiedString .Length- i].ToString();
            string firstCharacterAfterOperator = modifiedString[(modifiedString.Length - i) + 1].ToString();
            string secondCharacterAfterOperator = modifiedString[(modifiedString.Length - i) + 2].ToString();
            double doubleFirstOperand = double.Parse(firstCharacterAfterOperator);
            double doubleSecondOperand = double.Parse(secondCharacterAfterOperator);
                    
            if (randomOperatorInString == plus)
            {
                result = doubleFirstOperand + doubleSecondOperand;
                stringResult = System.Convert.ToString(result);
                modifiedString = modifiedString.Remove(modifiedString.Length - i, 3);
                modifiedString = modifiedString + System.Convert.ToString(result);
                firstPossiblePositionForOperator = modifiedString.Length - 3;
                //i = modifiedString.Length - 2;
                //text = text + modifiedString + ReturnModifiedString(modifiedString);
                //if (modifiedString.Length >= 3) text = "";
                //text = text + modifiedString + ReturnModifiedString(modifiedString);
                text = stringResult + ReturnModifiedString(modifiedString, firstPossiblePositionForOperator , text);
            }
            //i--;
            else 
            {
                text = stringResult + ReturnModifiedString(givenString, firstPossiblePositionForOperator - 1, text);
            }
        
                
                
                
            //if (modifiedString.Length >= 3)
            //    text = ReturnModifiedString(modifiedString);
                
                
            
            return text;


        }

        public string RemoveBlancSpacesFromString(string givenString)
        {
            string newString = "";
            for (int i = 0; i < givenString.Length; i++)
                if (givenString[i] != ' ')
                    newString = newString + givenString[i];
            return newString;
        }
    }
}
