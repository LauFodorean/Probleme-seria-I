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
           Assert.AreEqual(5, GenerateFibonacciRow(6));
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

        public int GenerateFibonacciRow(int n)
        {
            
            if (n > 2)
            {
                int current = 1;
                int previous = 1;
                for (int i = 3; i < n; i++)
                {
                    Swap(ref current, ref previous);
                    current += previous;
                }
                return current;
            }
            else
                return n;
            
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
