using System;
using Xunit;
using LinkedListClass;
using System.Threading.Tasks;
using NuGet.Frameworks;

namespace LinkedListTest
{
    public class LinkedList_Test
    {
        private LinkedList myList = new LinkedList();

        [Fact]
        public void CreateLinkedList_ItShouldBeEmpty()
        {
            Assert.True(myList.IsEmpty());
        }

        [Fact]
        public void PushLinkedList()
        {
            myList.Push(0);
            Assert.False(myList.IsEmpty());
        }

        [Fact]
        public void PushXRemoveX_ShouldBeEmpty()
        {
            myList.Push(0);
            myList.Remove(0);
            Assert.True(myList.IsEmpty());
        }

        [Fact]
        public void PushXandY_RemoveY_ShouldNotBeEmpty()
        {
            myList.Push(0);
            myList.Push(1);
            myList.Remove(1);
            Assert.False(myList.IsEmpty());
        }

        [Fact]
        public void PushX_CheckIfmyListContainsX()
        {
            myList.Push(0);
            Assert.True(myList.Contains(0));
        }

        [Fact]
        public void PushX_CountShouldBe1()
        {
            myList.Push(0);

            Assert.True(myList.Count() == 1);
        }

        [Fact]
        public void PushX_RemoveX_CountShouldBe0()
        {
            myList.Push(0);
            myList.Remove(0);


            Assert.True(myList.Count() == 0);
        }

        [Fact]
        public void GetHead_ShuoldReturnNullIfNothingIn()
        {
            Assert.True(myList.GetHead() == null);
        }

        [Fact]
        public void PushX_HeadOfListShouldHaveValueX()
        {
            myList.Push(0);

            Assert.True(myList.GetHead().GetValue() == 0);
        }

        [Fact]
        public void PushX_ThenY_YNextShouldBeX()
        {
            myList.Push(0);
            LinkedListNode x = myList.GetHead();
            myList.Push(1);
            LinkedListNode y = myList.GetHead();



            Assert.True(y.getNextNode() == x);
        }

        [Fact]
        public void CreateNode_ValueShouldBeValuePassed()
        {
            LinkedListNode node = new LinkedListNode(0);
       
            Assert.True(node.GetValue() == 0);
        }

        [Fact]
        public void InsertAtEnd_ShouldBeHeadIfEmpty()
        {          
            myList.InsertAtEnd(0);
        
            Assert.True(myList.GetHead().GetValue() == 0);
        }

        [Fact]
        public void InsertXandYatEnd_XShouldBeHead()
        {
            myList.InsertAtEnd(0);
            myList.InsertAtEnd(1);

    
            Assert.True(myList.GetHead().GetValue() == 0);
        }

        [Fact]
        public void GetLastValueOnEmptyListShouldBeNull()
        {
            Assert.True(myList.GetLastValue() == null);
        }

        [Fact]
        public void InsertAtEndOnEmptyList_LastValueShouldBeHead()
        {
            myList.InsertAtEnd(0);

            Assert.True(myList.GetHead() == myList.GetLastValue());
        }
        
        [Fact]
        public void PushX_ThenInsertAtEndY_LastValueShouldNotBeHead()
        {
            myList.Push(0);
            myList.InsertAtEnd(1);
            Assert.False(myList.GetHead() == myList.GetLastValue());
        }
        
    }
}
