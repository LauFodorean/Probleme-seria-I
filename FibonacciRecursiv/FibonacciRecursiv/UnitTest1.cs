using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciRecursiv
{
    [TestClass]
    public class UnitTest1
    {
         [TestMethod]
        public void CheckOfFibonacciGeneration()
        {
           Assert.AreEqual(5, Fibonacci(5));
        }
    
        public int Fibonacci(int n) 
        {
        int previous = 0;
        return Fibonacci(n, ref previous);
        }

        public int Fibonacci(int n, ref int previous) 
        {
        if (n < 2) return n;
        int beforePrevious = 0;
        previous = Fibonacci(n - 1, ref beforePrevious);
        return previous + beforePrevious;
        }
    }
}
