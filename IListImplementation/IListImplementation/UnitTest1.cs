using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace IListImplementation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddPosition()
        {
            SimpleListClass list = new SimpleListClass();
            Assert.AreEqual(list.contents[0] = 1, list.Add(1));
        }

        [TestMethod]
        public void ClearPositions()
        {
            SimpleListClass list = new SimpleListClass();
            list.contents[8] = {"1"};
            list.position = 2;
            CollectionAssert.AreEqual(new list.contents[8], list.Clear());

        }
    }

    public class SimpleListClass: IList
    {
        public object[] contents = new object[8];
        public int position = 0;
        
        public int Add(object value)
        {
            position++;
            int returnValue = (int)(contents[position - 1] = value);
            return returnValue;
        }

        public void Clear()
        {
            for (int i = 0; i < contents.Length; i++)
                contents[i] = null;
            position = 0;
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public bool IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
