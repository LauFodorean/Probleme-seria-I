using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace IListImplementation
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AddPosition()
        {
            SimpleList list = new SimpleList(new object[8], 1);
            Assert.AreEqual(1, list.Add(1));
        }

        [TestMethod]
        public void AddPositionWhenArrayLengthDoubles()
        {
            SimpleList list = new SimpleList(new object[8] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8);
            Assert.AreEqual(8, list.Add(9));
        }

        [TestMethod]
        public void listContainsASpecificValue()
        {
            SimpleList list = new SimpleList(new object[] { 1, 7, 8 }, 2);
            Assert.AreEqual(true, list.Contains(7));
        }

        [TestMethod]
        public void ClearList()
        {
            SimpleList list = new SimpleList(new object[] { 1, 2, 3 }, 2);
            SimpleList expectedResult = new SimpleList(new object[] { }, 0);
            list.Clear();
            CollectionAssert.AreEqual(expectedResult,list);

        }

        [TestMethod]
        public void RemoveObjectFromList()
        {
            SimpleList list = new SimpleList(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7);
            SimpleList newList = new SimpleList(new object[] { 1, 2, 4, 5, 6, 7, 8 }, 6);
            list.Remove(3);
            CollectionAssert.AreEqual(newList, list);

        }

        [TestMethod]
        public void RemoveObjectFromSpecifiedPosition()
        {
            SimpleList list = new SimpleList(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7);
            SimpleList newList = new SimpleList(new object[] { 1, 2, 4, 5, 6, 7, 8 }, 6);
            list.RemoveAt(2);
            CollectionAssert.AreEqual(newList, list);

        }

        [TestMethod]
        public void ObtainTheIndex()
        {
            SimpleList list = new SimpleList(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7);
            Assert.AreEqual(3, list.IndexOf(4));
        }

        [TestMethod]
        public void CountElementsInArray()
        {
            SimpleList list = new SimpleList(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7);
            int numberOfElements = list.Count;
            Assert.AreEqual(7, numberOfElements);
        }

        [TestMethod]
        public void CopyElementsToAnArrayStartingFromAPosition()
        {
            SimpleList list = new SimpleList(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7);
        }

    }
      
}
