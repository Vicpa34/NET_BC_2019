using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3App
{
    class Program
    {
        static void Main(string[] args)
        {
            UserList list = new UserList();  // 

            //1. Cyclically asks to add a user
            while (true)
            {
                //1.1 Input name
                //1.2 Input date (DateTime.TryParse)
                //1.3 Input gender (Enum.TryParse)

                //2. Izsauc lietotaja pievienosanu ar vertibam augstak
                list.Add();
                //3. Ja neizdevas pievienot attelo kludas pazinojumu
                //un sak 1. soli no jauna

            }
                                 
        }

            public static DateTime GetDate()
            {
                Console.Write("Enter  date: ");
                    string input = Console.ReadLine();

                if (DateTime.TryParse(input, out DateTime date))   // mes pasi definejam "date" as temp mainigais
                {
                    return date;
                }
                else 
                {
                    Console.WriteLine("Invalid date!");
                    return GetDate();
                }
            }

        public static UserProfile.Genders GetGender()
        {
            Console.Write("Enter your Gender: ");
            string input = Console.ReadLine();

            if (UserProfile.Genders.TryParse(input, out UserProfile.Genders gender))
            {
                return gender;
            }
            else
            {
                Console.WriteLine("Invalid gender");
                return GetGender();
            }


        }



               
        }
    }
}
