using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PascalTriangle
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestReturnPascalTriangleWhenItHasEightRows()
        {

            Assert.AreEqual("1   1 1   1 2 1   1 3 3 1   1 4 6 4 1   1 5 10 10 5 1   1 6 15 20 15 6 1   1 7 21 35 35 21 7 1   ", PascalTriangle(8));
        }
        
        [TestMethod]
        public void TestReturnPascalTriangleWhenItHasFourRows()
        {

            Assert.AreEqual("1   1 1   1 2 1   1 3 3 1   ", PascalTriangle(4));
        }
        
        [TestMethod]
        public void TestReturnPascalTriangleWhenItHasThreeRows()
        {

            Assert.AreEqual("1   1 1   1 2 1   ", PascalTriangle(3));
        }

        [TestMethod]
        public void TestReturnPascalTriangleWhenItHasTwoRows()
        {

            Assert.AreEqual("1   1 1   ", PascalTriangle(2));
        }

        [TestMethod]
        public void TestReturnPascalTriangleWhenItHasOneRow()
        {

            Assert.AreEqual("1   ", PascalTriangle(1));
        }

        [TestMethod]
        public void TestSumRowElements()
        {
            Assert.AreEqual(2, SumRowElements(1,1));
        }

        [TestMethod]
        public void TestConvertIntArrayToString()
        {
            Assert.AreEqual("1 3 3 1   ", ConvertIntArrayToString(new int[] {1,3,3,1}));
        }

        

        public int SumRowElements(int lastElement, int ElementBefore)
        {
            int sum = lastElement + ElementBefore;
            return sum;
        }

        public string PascalTriangle(int numberOfRows)
        {
            string text = "";
            int[] row1 = new int[1] { 1 };
            if (numberOfRows == 1)
                text = ConvertIntArrayToString(row1);

            int[] row2 = new int[2] { 1, 1 };
            if (numberOfRows == 2)
                text = ConvertIntArrayToString(row1) + ConvertIntArrayToString(row2);

            int currentRowNumber = 2;
            if (numberOfRows > 2)
                text = ConvertIntArrayToString(row1) + ConvertIntArrayToString(row2) + ReturnPascalTriangle(numberOfRows, row2, currentRowNumber);
            return text ;
        }

        public string ReturnPascalTriangle(int numberOfRows, int[] row2, int currentRowNumber)
        {
            int[] newRow = new int[row2.Length + 1];
            string text = "";
            
            if (currentRowNumber < numberOfRows)
            {
                newRow[0] = 1;
                newRow[newRow.Length - 1] = 1;

                for (int i = 0; i < row2.Length - 1; i++)
                {
                    newRow[i + 1] = SumRowElements(row2[i + 1 - 1], row2[i + 1]);
                }

                row2 = newRow;
                text = ConvertIntArrayToString(newRow) +  ReturnPascalTriangle(numberOfRows, row2, currentRowNumber + 1);
            }
            return text;
        }

        public string ConvertIntArrayToString(int[] givenArray)
        {
            string result = "";
            for (int i = 0; i < givenArray.Length ; i++)
                result = result + givenArray[(i + 1) - 1].ToString() + " ";
            return result + "  ";
        }
        
        
    }
}
