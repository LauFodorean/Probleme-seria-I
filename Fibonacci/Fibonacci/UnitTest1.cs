using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckOfFibonacciGeneration()
        {
           CollectionAssert.AreEqual(new int[] { 0, 1, 1, 2, 3, 5}, GenerateFibonacciRow(5));
        }

        [TestMethod]
        public void CheckOfSwapMethod()
        {
            int a = 1;
            int b = 2;
            Swap(ref a, ref b);
            int[] swapedResult = new int[] { a, b };
            CollectionAssert.AreEqual( new int[] {2,1}, swapedResult);
        }

        public int[] GenerateFibonacciRow(int n)
        {
            int[] fibonacciRow = new int[] {0, 1, 1};
            if (n >2 )
                {
                int newLength = n+1;
                Array.Resize(ref fibonacciRow, newLength);
                int current = 1;
                int previous = 1;
                for (int i = 3; i < newLength; i++)
                {
                    Swap(ref current, ref previous);
                    current += previous;
                    fibonacciRow[i] = current;
                }

            }
            return fibonacciRow;
        }

        public void Swap(ref int a, ref int b)
        {
            int pivot = 0;
            pivot = a;
            a = b;
            b = pivot;
        }
    }
}
