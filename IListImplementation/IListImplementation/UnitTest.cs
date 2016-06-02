using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace IListImplementation
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AddPosition()
        {
            var list = new SimpleList<int>() { };
            Assert.AreEqual(0, list.Add(1));
        }

        [TestMethod]
        public void AddPositionWhenArrayLengthDoubles()
        {
            var list = new SimpleList<int>(){ 1, 2, 3, 4, 5, 6, 7, 8};
            Assert.AreEqual(8, list.Add(9));
        }

        [TestMethod]
        public void listContainsASpecificValue()
        {
            var list = new SimpleList<int>(){ 1, 7, 8 };
            Assert.AreEqual(true, list.Contains(7));
        }

        [TestMethod]
        public void ClearList()
        {
            var list = new SimpleList<int>() { 1, 2, 3 };
            list.Clear();
            int[] clearedList = { 0, 0, 0, 0, 0, 0, 0, 0};
            CollectionAssert.Equals(clearedList, list);
        }


        [TestMethod]
        public void RemoveObjectFromList()
        {
            var list = new SimpleList<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var newList = new SimpleList<int>() { 1, 2, 4, 5, 6, 7, 8 };
            list.Remove(3);
            CollectionAssert.Equals(newList, list);
        }

        [TestMethod]
        public void RemoveObjectFromSpecifiedPosition()
        {
            var list = new SimpleList<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var newList = new SimpleList<int>() { 1, 2, 4, 5, 6, 7, 8 };
            list.RemoveAt(2);
            CollectionAssert.Equals(newList, list);
        }

        [TestMethod]
        public void ObtainTheIndex()
        {
            var list = new SimpleList<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.AreEqual(3, list.IndexOf(4));
        }

        [TestMethod]
        public void CountElementsInArray()
        {
            var list = new SimpleList<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            int numberOfElements = list.Count;
            Assert.AreEqual(8, numberOfElements);
        }

        //[TestMethod]
        //public void CopyElementsToAnArrayStartingFromAPosition()
        //{
        //    var list = new SimpleList<int>(){ 1, 2, 3, 4, 5, 6, 7, 8 };
        //    Array[] arrayToBeCopiedTo = new Array[] { };
        //    list.CopyTo(arrayToBeCopiedTo, 2);
        //    CollectionAssert.AreEqual(new object[] { 3, 4, 5, 6, 7, 8 }, list);
        //}

        [TestMethod]
        public void InserItemAtPosition()
        {
            var list = new SimpleList<int>() { 1, 2, 3, 4 };
            list.Insert(4, 5);
            var list2 = new SimpleList<int>() { 1, 2, 3, 4, 5 };
            CollectionAssert.Equals(list2, list);
        }
    }
      
}
