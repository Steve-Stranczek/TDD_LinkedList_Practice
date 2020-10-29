using System;
using Xunit;
using ConsoleApp1;
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
        public void PushXandY_RemoveY_ShuoldNotBeEmpty()
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
            bool resultOfCount = myList.Count() == 1;
            Assert.True(resultOfCount);
        }

        [Fact]
        public void PushX_RemoveX_CountShouldBe0()
        {
            myList.Push(0);
            myList.Remove(0);
            bool resultOfCount = myList.Count() == 0;

            Assert.True(resultOfCount);
        }

        [Fact]
        public void PushX_HeadOfListShouldHaveValueX()
        {
            myList.Push(0);
            bool compareHeadToX = myList.GetHead().GetValue() == 0;

            Assert.True(compareHeadToX);
        }

        [Fact]
        public void CreateNode_ValueShouldBeValuePassed()
        {
            LinkedListNode node = new LinkedListNode(0);
            bool resultOfValueComparison = node.GetValue() == 0;

            Assert.True(resultOfValueComparison);
        }

        
    }
}
