using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListClass
{
    public interface ILinkedList
    {
        public LinkedListNode GetHead();

        public bool IsEmpty();

        public void Push(int element);

        public void Remove(int element);

        public bool Contains(int element);

        public int Count();

        public void InsertAtEnd(int element);

        public void InsertAfter(LinkedListNode nodeToInsertAfter, int element);

        public LinkedListNode GetLastValue();

        public LinkedListNode GetNodeByValue(int element);
        
    }
}
