using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebShop.Logic;

namespace WebShopLogicTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetByEmailAndPassword()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            var result = manager.GetByEmailAndPassword("pete@gmail.com", "pete");

            Assert.AreEqual("pete@gmail.com", result.Email);
            Assert.AreEqual("pete", result.Password);

            var result2 = manager.GetByEmailAndPassword("pete2@gmail.com", "pete2");

            Assert.IsNull(result2);

            var result3 = manager.GetByEmailAndPassword("pete@gmail.com", "lisa");

            Assert.AreEqual("pete@gmail.com", result.Email);  //pareizs epasts
            Assert.IsNull("lisa", result.Password);           //nepareiza parole                        

        }
        [TestMethod]
        public void TestUserCreate()
        {
            UserManager manager = new UserManager();
            User user = manager.Create(new User()
            {
                Id = 3,
                Email = "lisa@gmail.com",
                Password = "lisa"

            });
            Assert.AreEqual(3, user.Id);
            Assert.AreEqual("lisa@gmail.com", user.Email);
            Assert.AreEqual("lisa", user.Password);

        }
        [TestMethod]
        public void TestGetByEmail()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            User user1 = manager.GetByEmail("pete@gmail.com");
            User user2 = manager.GetByEmail("ann@gmail.com");

            Assert.AreEqual(1, "pete@gmail.com", "pete", user1.Id, user1.Email, user1.Password);
            Assert.AreEqual(1, user1.Id);
            Assert.AreEqual(2, "ann@gmail.com", "ann", user2.Id, user2.Email, user2.Password);
        }
        [TestMethod]
        public void TestDelete()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            manager.Delete(1);

            var deletedUser = manager.GetById(1);

            Assert.IsNull(deletedUser);
        }

        [TestMethod]

        public void TestGetByCategory()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();

            var result = manager.GetByCategory(1);

            Assert.AreEqual(1, result.categoryId);

        }

    }
}
