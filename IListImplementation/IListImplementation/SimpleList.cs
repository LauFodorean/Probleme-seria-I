using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IListImplementation
{
    public class SimpleList<T> : IList<T>
    {
        private T[] contents = new T[8];
        private int position = 0;

        public SimpleList()
        {
           
        }

        public int Add(T value)
        {
            if (position == contents.Length - 1) Array.Resize(ref contents, contents.Length * 2);
            if (position < contents.Length )
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
                contents[i] = default(T);
               //CopyTo(contents, i);
            position = 0;
        }

        public bool Contains(T value)
        {
            bool result = false;
            for (int i = 0; i <= contents.Length -1 ; i++)
            {
                if (contents[i].Equals(value)) return result = true;
            }
            return result;
        }

        public int IndexOf(T value)
        {
            int theIndex = -1;
            for (int i = 0; i <= position; i++)
                if (contents[i].Equals(value))
                {
                    return theIndex = i;
                }

            return theIndex;
        }

        public void Insert(int index, T value)
        {
            if ((position + 1 <= contents.Length) && (index < contents.Length-1) && (index >= 0))
            {
            position++;

            for (int i = contents.Length - 1; i > index; i--)
            {
                contents[i] = contents[i - 1];
            }
            contents[index] = value;
            }
        }

        public bool IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public void Remove(T value)
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

        public T this[int index]
        {
            get
            {
                return contents[index];
            }
            set
            {
                contents[index] = value; ;
            }
        }

        public void CopyTo(T[] array, int index)
        {
            int j = 0;
            for (int i = index; i < position; i++)
            {
                array.SetValue(contents[i],j);
                j++;
            };
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

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < position; i++)
                yield return (T)contents[i];
        }


        T IList<T>.this[int index]
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

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
