using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicSample.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAllUsers()  //name shouldn`t have to be same as method
        {
            UserManager manager = new UserManager();
            manager.Seed();                //naselili users - 2 users must be

            var result = manager.GetAll();

            Assert.AreEqual("Name 1", result[0].Name);
            Assert.AreEqual(2, result.Count);
        }                                     // upper button Test => Test explorer

        [TestMethod]
        public void TestCreateUser()
        {
            UserManager manager = new UserManager();
            User user = manager.CreateNew(new User()
            {
                Name = "new name"
            });

            Assert.AreEqual("new name", user.Name);
            Assert.IsTrue(user.Id > 0);
        }

        [TestMethod]
        public void TestGetuser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            User user1 = manager.Get(1);
            User user2 = manager.Get(2);
            User user3 = manager.Get(3);

            Assert.AreEqual("Name 1", user1.Name);
            Assert.AreEqual("Name 2", user2.Name);
            Assert.IsNull(user3);
        }
        [TestMethod]
        public void TestDeleteUser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            manager.delete(1);

            var allUsers = manager.GetAll();
            var deletedUser = manager.Get(1);


            Assert.AreEqual(1, allUsers.Count);
            Assert.IsNull(deletedUser);
        }

    }
}
