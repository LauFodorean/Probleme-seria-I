using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularyDoubleLinkedListImp
{

    public class Node
    {
        public Node next;
        public Node previous;
        public int value;

        public Node(int value)
        {
            this.value = value;
        }
    }
    public class CircularyDoubleLinkedList<T> : ICollection<T>
    {
        private Node head;
        private Node tail;
        public int count;

        public CircularyDoubleLinkedList()
        {
            count = 0;
        }
        
        public void addNode(int value)
        {
            Node newNode = new Node(value);

            if (count ==0)
            {
                head = newNode;
                head.next = head;
                head.previous = head;
                tail = head;
            }
            else
            {
                newNode.next = head;
                newNode.previous = tail;
                tail.next = newNode;
                head.previous = newNode;
                tail = newNode;
            }
            count++;
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
