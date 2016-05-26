using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IListImplementation
{
    public class SimpleList : IList
    {
        private object[] contents = new object[8];
        private int position;

        public SimpleList(object[] contents, int position)
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
            for (int i = 0; i <= position; i++)
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
            if ((index >= 0) && (index < position))
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
