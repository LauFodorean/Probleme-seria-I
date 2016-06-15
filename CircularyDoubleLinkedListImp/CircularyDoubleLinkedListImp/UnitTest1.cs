using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircularyDoubleLinkedListImp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddElementToEmptyList()
        {
            var list = new CircularyDoubleLinkedList<int>();
            list.addNode(1);
            var enlagredList = new CircularyDoubleLinkedList<int>();
            enlagredList.count = 1;
            Assert.AreEqual(new CircularyDoubleLinkedList<int>(), list);
        }

        //[TestMethod]
        //public void AddElementToAListWithElements()
        //{
        //    CircularyDoubleLinkedList list = new CircularyDoubleLinkedList()
        //}
    }
}
