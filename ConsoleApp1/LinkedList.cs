using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LinkedList
    {
        private int numOfElements = 0;
        public LinkedList()
        {

        }

        public bool IsEmpty()
        {
            return numOfElements == 0;
        }

        public void Insert(int element)
        {
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
            return  numOfElements;
        }

    }
}
