using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3App
{
    class UserListExceptions : Exception
    {
        public UserListExceptions(string message)
            : base(message) //base is constructor for Exception in built class, message is given to base
        {

        }
    }

}
