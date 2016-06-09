using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularyDoubleLinkedListImp
{
    public class CircularyDoubleLinkedList
    {
        private Node head;
        private Node dlList;
        private int count;

        public CircularyDoubleLinkedList()
        {
            count = 0;
        }
        
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

        public void addNode(int value)
        {
            Node newNode = new Node(value);

            if (count ==0)
            {
                dlList = newNode;
                dlList.next = dlList;
                dlList.previous = dlList;
                head = dlList;
            }
            else
            {
                newNode.previous = dlList.previous;
                newNode.next = dlList;
                dlList.previous.next = newNode;
                dlList.previous = newNode;
                head = dlList;
            }
            count++;
        }
    }
}
