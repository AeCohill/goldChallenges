using Cafe_Menu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CafeMenu_Tests
{
    [TestClass]
    public class CafeTests
    {
        [TestMethod]
        public void TestMethod_AddItemToMenu()
        {
            //Arrange
            Menu menu = new Menu();

            Menu_Repository menu_Repository = new Menu_Repository();

            List<Menu> localList = menu_Repository.GetMenuItems();

            //act
            int beforeCount = localList.Count;
            menu_Repository.AddItemToMenu(menu);
            int actual = localList.Count;
            int expected = beforeCount + 1;




            //Assert
            Assert.AreEqual(expected, actual);




        }

    }
}
