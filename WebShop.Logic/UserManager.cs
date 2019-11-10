using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class UserManager: BaseManager<User>
    {
        public UserManager(WebShopDb db)
            :base (db)
        {
            
        }

        //public UserManager()
        //{
        //}

        //public UserManager()
        //{
        //}

        //public UserManager()
        //{
        //}

        protected override DbSet<User> Table
        {
            get 
            {
                return _db.Users;
            }
        }
        //private int CurrentId;
        //private static List<User> Users = new List<User>();

        //public UserManager()
        //{
        //    CurrentId = 1000;
        //}

        public User GetByEmailAndPassword(string email, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            return user;
        }

        //public User Create(User user)
        //{
        //    //user.Id = CurrentId;
        //    //Users.Add(user);
        //    //CurrentId++;
        //    _db.Users.Add(user);
        //    _db.SaveChanges();
        //    return user;
        //}

        public User GetByEmail(string email)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == email);

            return user;
        }

        //public void Delete(int id)
        //{
        //    var user = _db.Users.FirstOrDefault(u => u.Id == id);
        //    _db.Users.Remove(user);
        //    _db.SaveChanges();
        //}

        //public void Update(User user)
        //{
        //    var currentUser = _db.Users.FirstOrDefault(u => u.Id == user.Id);
        //    currentUser.Email = user.Email;
        //    currentUser.Password = user.Password;

        //    _db.SaveChanges();
        //}

        public void Seed()
        {
            //Users.Add(new User()
            //{
            //    Id = 1,
            //    Email = "test@mail.com",
            //    Password = "pass123"
            //});
        }
    }
}