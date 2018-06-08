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

            //check to see that valuetoAdd which is 20, is at index 0.




            //act
            list.Add(valueToAdd);
            int actualValue = list[0];







            //assert
            Assert.AreEqual(expectedValue, actualValue);
        } 

