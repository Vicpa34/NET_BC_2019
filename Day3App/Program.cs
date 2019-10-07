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
                string name = GetText();
                //1.2 Input date (DateTime.TryParse)
                DateTime birthDate = GetDate();
                //1.3 Input gender (Enum.TryParse)
                UserProfile.Genders gender = GetGender();

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
            string value = Console.ReadLine();

            if (UserProfile.Genders.TryParse(value, out UserProfile.Genders gender))  //or  if (Enum.TryParse(value, true, out UserProfile.Genders gender))
            {                                                                         // true - ignoring entered BIG SMALL letters  
                return gender;
            }
            else
            {
                Console.WriteLine("Incorrect value");
                return GetGender();
            }


        }
        public static string GetText()     //checking name if there are empty spaces
        {
            Console.Write("Enter  name: ");
            string name = Console.ReadLine();
            name = name.Trim();                // trimming - taking out blank spaces

            if (!String.IsNullOrEmpty(name)) 
            {
                return name;
            }
            else
            {
                Console.WriteLine("Empty text!");
                return GetText();
            }
        }




    }
    }
}
