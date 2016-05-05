using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace IListImplementation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void insertPositionInArrayTestMetod()
        {
            object[] givenStringArray = {"one"};
            Assert.AreEqual("one", Add(givenStringArray[givenStringArray.Length-1]));
        }
    }

    public class SimpleList: IList
    {
        private object[] _contents = new object[8];
        private int _count;

        public int SimpleList()
        {
           return _count = 0;
        }

        public int Add (object value)
        {
            return 0;
        }
    }
}
