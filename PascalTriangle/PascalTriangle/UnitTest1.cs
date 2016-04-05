using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PascalTriangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReturnPascalTriangleWhenItHasThreeRows()
        {
            
            CollectionAssert.AreEqual(new string[] { "1","11","121"} , ReturnPascalTriangle(3));
        }

        [TestMethod]
        public void TestReturnPascalTriangleWhenItHasTwoRows()
        {

            CollectionAssert.AreEqual(new string[] { "1", "11" }, ReturnPascalTriangle(2));
        }

        [TestMethod]
        public void TestReturnPascalTriangleWhenItHasOneRow()
        {

            CollectionAssert.AreEqual(new string[] { "1" }, ReturnPascalTriangle(1));
        }

        [TestMethod]
        public void TestSumRowElements()
        {
            Assert.AreEqual(2, SumRowElements(1,1));
        }

        [TestMethod]
        public void TestConvertIntArrayToString()
        {
            Assert.AreEqual("1331", ConvertIntArrayToString(new int[] {1,3,3,1}));
        }

        

        public int SumRowElements(int lastElement, int ElementBefore)
        {
            int sum = lastElement + ElementBefore;
            return sum;
        }

        public string[] ReturnPascalTriangle(int numberOfRows)
        {
            string[] text = new string[numberOfRows];
            int[] row1 = new int[1] { 1 };
            text[0] = ConvertIntArrayToString(row1);
             
            int[] row2 = new int[2] { 1, 1 };
            text[1] = ConvertIntArrayToString(row2);
            
            int currentRowNumber = 1;
            int[] newRow = new int[row2.Length+1];
            newRow[0] = 1;
            newRow[newRow.Length - 1] = 1;
                       
            if ( numberOfRows > 2 )
                                
                for (int i = 0; i < row2.Length-1 ; i++)
                {
                    newRow[i + 1] = SumRowElements(row2[i + 1 - 1], row2[i+1]);
                }
            currentRowNumber++;
            row2 = newRow;
            text[currentRowNumber] = ConvertIntArrayToString(newRow);
            return text;
        }

        public string ConvertIntArrayToString(int[] givenArray)
        {
            string result = "";
            for (int i = 0; i < givenArray.Length ; i++)
                result = result + givenArray[(i + 1) - 1].ToString();
            return result;
        }
        
        
    }
}
