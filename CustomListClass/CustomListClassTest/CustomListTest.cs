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

        
}
