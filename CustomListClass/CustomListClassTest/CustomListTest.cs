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
            int value = 1;



            //act
            list.add(value);







            //assert
            Assert.AreEqual(1, value);
            
        }
    }
}
