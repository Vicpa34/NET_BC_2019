using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class User:BaseData
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int id, string email, string password)
        {
            Id = id;
            Email = email;
            Password = password;
        }

        public User()
        {

        }
    }
    
}
