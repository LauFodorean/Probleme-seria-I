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
            SimpleListClass list = new SimpleListClass(new object[8], 1);
            Assert.AreEqual(1, list.Add(1));
        }

        [TestMethod]
        public void AddPositionWhenArrayLengthDoubles()
        {
            SimpleListClass list = new SimpleListClass(new object[8] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8);
            Assert.AreEqual(8, list.Add(9));
        }

        [TestMethod]
        public void listContainsASpecificValue()
        {
            SimpleListClass list = new SimpleListClass(new object[] { 1, 7, 8 }, 2);
            Assert.AreEqual(true, list.Contains(7));
        }

        [TestMethod]
        public void ClearList()
        {
            SimpleListClass list = new SimpleListClass(new object[] { 1, 2, 3 }, 2);
            SimpleListClass expectedResult = new SimpleListClass(new object[] { }, 0);
            list.Clear();
            CollectionAssert.AreEqual(expectedResult,list);

        }

        [TestMethod]
        public void RemoveObjectFromList()
        {
            SimpleListClass list = new SimpleListClass(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7);
            SimpleListClass newList = new SimpleListClass(new object[] { 1, 2, 4, 5, 6, 7, 8 }, 6);
            list.Remove(3);
            CollectionAssert.AreEqual(newList, list);

        }

        [TestMethod]
        public void RemoveObjectFromSpecifiedPosition()
        {
            SimpleListClass list = new SimpleListClass(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7);
            SimpleListClass newList = new SimpleListClass(new object[] { 1, 2, 4, 5, 6, 7, 8 }, 6);
            list.RemoveAt(2);
            CollectionAssert.AreEqual(newList, list);

        }

        [TestMethod]
        public void ObtainTheIndex()
        {
            SimpleListClass list = new SimpleListClass(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7);
            Assert.AreEqual(3, list.IndexOf(4));
        }

        [TestMethod]
        public void CountElementsInArray()
        {
            SimpleListClass list = new SimpleListClass(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7);
            int numberOfElements = list.Count;
            Assert.AreEqual(7, numberOfElements);
        }

        [TestMethod]
        public void CopyElementsToAnArrayStartingFromAPosition()
        {
            SimpleListClass list = new SimpleListClass(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7);
        }

    }

    public class SimpleListClass: IList
    {
        private object[] contents = new object[8];
        private int position;
        
        public SimpleListClass(object[] contents, int position)
        {
            this.contents = contents;
            this.position = position;
        }
        
        public int Add(object value)
        {
            if (position >= contents.Length - 1) Array.Resize(ref contents, contents.Length * 2);
            if (position < contents.Length)
            {
                contents[position] = value;
                position += 1;
                return position - 1;
            }
                      
            return -1;
        }

        public void Clear()
        {
            for (int i = 0; i <= position; i++)
                contents[i] = null;
            position = 0;
        }

        public bool Contains(object value)
        {
            bool result = false;
            for (int i = 0; i <= position; i++)
            {
                if (contents[i].Equals(value)) result = true;
            }                       
            return result;
        }

        public int IndexOf(object value)
        {
            int theIndex = -1;
            for (int i = 0; i <= position ; i++)
                if (contents[i].Equals(value))
                {
                    return theIndex = i;
                }

            return theIndex;
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
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ( ( index >= 0 ) && (index < position ) )
            {
                for (int j = index; j < position - 1; j++)
                { contents[j] = contents[j + 1]; }
                position--;
            }
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
            get { return position; }
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
            for (int i = 0; i < position; i++)
                yield return contents[i];
        }
    }
}
