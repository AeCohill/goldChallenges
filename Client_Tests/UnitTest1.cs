using Greeting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Client_Tests
{
    [TestClass]
    public class UnitTest1
    {

        //Client_Repo _greetingsTestRepo;
        //private Client person2 = new Client("Jack", "Ryan", "It's been a long time since we've heard from you, we want you back.");
        //[TestMethod]
        //public void SetTestContent()
        //{
        //    _greetingsTestRepo = new Client_Repo();
        //    _greetingsTestRepo.AddNewClient(person2);
        //}
        [TestMethod]
        public void AddNewClient_test()
        {
            //Arrange
            Client menu = new Client();

            Client_Repo client_Repository = new Client_Repo();

            List<Client> localList = client_Repository.GetClient();

            //act
            int beforeCount = localList.Count;
            client_Repository.AddNewClient(menu);
            int actual = localList.Count;
            int expected = beforeCount + 1;




            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Delete_TestMethod()
        {
            Client menu = new Client();
            Client_Repo repo = new Client_Repo();
            repo.AddNewClient(menu);

            List<Client> list = repo.GetClient();


            int initial = list.Count;
            repo.DeleteExistingClient(menu.ClientNum);
            int actual = list.Count;
            int expected = initial - 1;

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void UpdateClien_TestMethod()
        {
            Client menu = new Client();
            Client_Repo repo = new Client_Repo();
            List<Client> localList = repo.GetClient();
            int clientNum = menu.ClientNum;
            repo.AddNewClient(menu);



            Assert.IsNotNull(menu.ClientNum);


        }


    }
}
