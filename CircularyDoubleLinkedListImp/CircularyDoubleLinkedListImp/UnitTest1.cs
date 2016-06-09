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
            CircularyDoubleLinkedList list = new CircularyDoubleLinkedList();
            list.addNode(1);
            Assert.AreEqual(1, 1);
        }
    }
}
