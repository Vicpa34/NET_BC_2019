using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3App
{
    class UserProfile
    {
        string FullName;
        enum Gender
        {
            m,
            f
        }
        DateTime birthDate;

        public static int GetAge(DateTime birthDate)
        {
            DateTime n = DateTime.Now; // To avoid a race condition around midnight
            int age = n.Year - birthDate.Year;

            if (n.Month < birthDate.Month || (n.Month == birthDate.Month && n.Day < birthDate.Day))
                age--;

            return age;
        }
         

        
    }
}
