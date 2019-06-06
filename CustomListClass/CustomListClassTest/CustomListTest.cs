using System;
using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CustomListClassTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_Int_To_List_Check_Count()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedCount = 1;
            int valueToAdd = 20;

            //act
            list.Add(valueToAdd);
            int actualCount = list.Count;

            //assert
            Assert.AreEqual(expectedCount, actualCount);

        }

        [TestMethod]
        public void Add_Int_To_List_Check_Specific_Index()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 20;
            int valueToAdd = 20;

            //check to see that valuetoAdd which is 20, is at index 0

            //act
            list.Add(valueToAdd);
            int actualValue = list[0];

            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Add_Int_To_List_Check_That_Capacity_Changes_If_More_Items_Are_Added_To_List()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedCapacity = 10;
            int valueToAdd = 20;

            //act
            list.Add(valueToAdd);
            list.Add(valueToAdd);
            list.Add(valueToAdd);
            list.Add(valueToAdd);
            list.Add(valueToAdd);
            list.Add(valueToAdd);
            int actualCapacity = list.Capacity;

            //assert
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }

        [TestMethod]
        public void Remove_Item_From_List_Check_Count()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedCount = 5;
            int valueToRemove = 15;
            
      




            //act
            list.Add(10);
            list.Add(valueToRemove);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Remove(valueToRemove);
            int actualCount = list.Count;


            //assert
            Assert.AreEqual(expectedCount, actualCount);
            
        }

        [TestMethod]
        public void Remove_Item_From_List_Check_Indexes_Of_List()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedValue = 10;

            //act
            list.Add(10);
            list.Add(20);
            list.Remove(20);
            int actualValue = list[0];
            

            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Remove_Item_From_List_Check_That_Capacity_Changes_If_More_Items_Are_Removed()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int expectedCapacity = 5;

            //act
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);
            list.Remove(60);
            int actualCapacity = list.Capacity;
            //assert
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }
    }
}






