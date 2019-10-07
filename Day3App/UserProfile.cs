using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3App
{
    class UserProfile
    {
        
        public enum Genders
        {
            m,
            f
        }
        public string Name { get; set; }
        public DateTime date { get; set; }

        public Genders Gender { get; set; }

        public int GetAge()
        {
            DateTime n = DateTime.Now; 
            int age = n.Year - date.Year;

            if (n.Month < date.Month || (n.Month == date.Month && n.Day < date.Day))
                age--;

            return age;
        }

        public UserProfile(string name, DateTime date, Genders gender)
        {
            Name = name;
            this.date = date;
            Gender = gender;
        }
    }
}
