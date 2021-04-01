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
        [TestMethod]
        public void Delete_TestMethod()
        {
            Menu menu = new Menu();
            Menu_Repository repo = new Menu_Repository();
            repo.AddItemToMenu(menu);

            List<Menu> list = repo.GetMenuItems();


            int initial = list.Count;
            repo.DeleteFromMenu(menu.MealNum);
            int actual = list.Count;
            int expected = initial - 1;

            Assert.AreEqual(expected, actual);

            
        }
        [TestMethod]
        public void Delete_Test_False()
        {

            Menu menu = new Menu();
            Menu_Repository repo = new Menu_Repository();
            repo.AddItemToMenu(menu);

            List<Menu> list = repo.GetMenuItems();


            int initial = list.Count;
            repo.DeleteFromMenu(menu.MealNum);
            int actual = list.Count;
            int expected = initial + 1;

            Assert.AreNotEqual(expected, actual);


        }
        [TestMethod]
        public void GetItemId()
        {
            
            Menu menu = new Menu();
            Menu_Repository repo = new Menu_Repository();
            repo.AddItemToMenu(menu);
            List<Menu> list = repo.GetMenuItems();
            int initial = list.Count;
            repo.GetItemID(menu.MealNum);

            int actual = list.Count;
            int expected = initial;

            Assert.IsNotNull(menu.MealNum);
           



            

           

            

        }




    }
}
