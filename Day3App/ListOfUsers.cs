using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3App
{
    class UserList
    {
        private List<UserProfile> users = new List<UserProfile>();

        public void Add(string fullName, UserProfile.Genders gender, DateTime date)   //function to add new users lietotajus
        {
            //parbaudes
            //1. Date cannot be in the future
            if (date > DateTime.Now)
            {
                throw new UserListExceptions("Entered date is invalid!");
            }
            //2. Date cant be less than 01.01.1900
            DateTime date2 = new DateTime(1900, 1, 1, 0, 0, 0);
            if (date < date2 )
            {
                throw new UserListExceptions("Entered date is less than 01.01.1900!");
            }
            //3. Full name cannot exceed 20 symbols
            int length = fullName.Length;
            if (length > 20)
            {
                throw new UserListExceptions("Your name exceed 20 symbols!");
            }

            //
            UserProfile user = new UserProfile(fullName, date, gender);
            users.Add(user);

        }
        
    }
}
