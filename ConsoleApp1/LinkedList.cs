using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListClass
{
    public class LinkedList : ILinkedList
    {
        private int numOfElements = 0;
        private LinkedListNode Head;

        public LinkedList()
        {
            Head = null;
        }

        public LinkedListNode GetHead()
        {
            return this.Head;
        }

        public bool IsEmpty()
        {
            return numOfElements == 0;
        }

        public void Push(int element)
        {
            LinkedListNode newNode = new LinkedListNode(element);
            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.SetNextNode(Head);
                Head = newNode;
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

        public void InsertAtEnd(int element)
        {
            if(this.Head == null)
            {
                this.Head = new LinkedListNode(element);
            }
            else
            {
                LinkedListNode CurrentLastValue = GetLastValue();
                CurrentLastValue.SetNextNode(new LinkedListNode(element));
            }
        }

        public void InsertAfter(LinkedListNode nodeToInsertAfter, int element)
        {
            throw new NotImplementedException();
        }

        public LinkedListNode GetLastValue()
        {
            if (Head == null) return null;
            else
            {
                LinkedListNode traversalNode = Head;
                while (traversalNode.getNextNode() != null)
                {
                    traversalNode = traversalNode.getNextNode();
                }
                return traversalNode;
            }

        }
    }

    public class LinkedListNode
    {
        private int Value;
        private LinkedListNode Next;

        public LinkedListNode(int value)
        {
            this.Value = value;
            Next = null;
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
