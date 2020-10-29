using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListClass
{
    public class LinkedList : ILinkedList
    {
        //This linked list can only contain one of each element
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
                numOfElements++;
            }
            else
            {
                if (!Contains(element))
                {
                    newNode.SetNextNode(Head);
                    Head = newNode; 
                    numOfElements++;
                }
            }
           
        }

        public void Remove(int element)
        {

            LinkedListNode traversalNode = Head;
            LinkedListNode previous = Head;
            while (traversalNode != null)
            {
                if (traversalNode.GetValue() == element)
                {
                    if (traversalNode == this.Head)
                    {
                        Head = Head.getNextNode();
                    }
                    else
                    {
                        previous.SetNextNode(traversalNode.getNextNode());
                    }
                    numOfElements--;
                }
                previous = traversalNode;
                traversalNode = traversalNode.getNextNode();
            }
        }

        public bool Contains(int element)
        {
            if (numOfElements == 0)
            {
                return false;
            }
            else
            { 
                LinkedListNode traversalNode = Head;
                while (traversalNode != null)
                {
                    if(traversalNode.GetValue() == element)
                    {
                        return true;
                    }
                    traversalNode = traversalNode.getNextNode();
                }
                return false;
            }

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

        public LinkedListNode GetNodeByValue(int element)
        {
            LinkedListNode traversalNode = Head;
            while (traversalNode != null)
            {
                if (traversalNode.GetValue() == element)
                {
                    return traversalNode;
                }
                traversalNode = traversalNode.getNextNode();
            }
            return null;
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
