using System;
using Xunit;
using ConsoleApp1;
using System.Threading.Tasks;
using NuGet.Frameworks;

namespace LinkedListTest
{
    public class UnitTest1
    {
        private LinkedList myList = new LinkedList();

        [Fact]
        public void CreateLinkedList_ItShouldBeEmpty()
        {
            Assert.True(myList.IsEmpty());
        }

        [Fact]
        public void InsertIntoLinkedList()
        {
            myList.Insert(0);
            Assert.False(myList.IsEmpty());
        }

        [Fact]
        public void InsertXRemoveX_ShouldBeEmpty()
        {
            myList.Insert(0);
            myList.Remove(0);
            Assert.True(myList.IsEmpty());
        }

        [Fact]
        public void InsertXandY_RemoveY_ShuoldNotBeEmpty()
        {
            myList.Insert(0);
            myList.Insert(1);
            myList.Remove(1);
            Assert.False(myList.IsEmpty());
        }

        [Fact]
        public void InsertX_CheckIfmyListContainsX()
        {
            myList.Insert(0);
            Assert.True(myList.Contains(0));
        }

        [Fact]
        public void InsertX_CountShouldBe1()
        {
            myList.Insert(0);
            bool resultOfCount = myList.Count() == 1;
            Assert.True(resultOfCount);
        }

        [Fact]
        public void InsertX_RemoveX_CountShouldBe0()
        {
            myList.Insert(0);
            myList.Remove(0);
            bool resultOfCount = myList.Count() == 0;

            Assert.True(resultOfCount);
        }
    }
}
