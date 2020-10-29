using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LinkedList
    {
        private int numOfElements = 0;
        private LinkedListNode head;

        public LinkedList()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return numOfElements == 0;
        }

        public void Push(int element)
        {
            LinkedListNode newNode = new LinkedListNode(element);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.SetNextNode(head);
                head = newNode;
            }
            numOfElements++;
        }

        public void Remove(int element)
        {
            numOfElements--;
        }

        public bool Contains(int element)
        {
            return true;
        }

        public int Count()
        {
            return numOfElements;
        }


    }

    public class LinkedListNode
    {
        private int Value;
        private LinkedListNode Next;

        public LinkedListNode(int value)
        {

        }

        public void SetNextNode(LinkedListNode nextNode)
        {
            this.Next = nextNode;
        }

        public int GetValue()
        {
            return this.Value;
        }

        public LinkedListNode getNextNode()
        {
            return this.Next;
        }

    }
}
