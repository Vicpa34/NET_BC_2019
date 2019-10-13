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
            try 
                { 
                UserList list = new UserList();  // 

            
                //1. Cyclically asks to add a user
                while (true)
                {
                    try
                    { 
                    //1.1 Input name
                    string name = ConsoleInput.GetText();
                    //1.2 Input date (DateTime.TryParse)
                    DateTime birthDate = ConsoleInput.GetDate();
                    //1.3 Input gender (Enum.TryParse)
                    UserProfile.Genders gender = GetGender();

                    //2. Izsauc lietotaja pievienosanu ar vertibam augstak
                    list.Add(name, gender, birthDate);
                        //3. Ja neizdevas pievienot attelo kludas pazinojumu
                        //un sak 1. soli no jauna

                        Console.WriteLine("Add another? (y/n)");
                        string input = Console.ReadLine().ToLower();
                        if(input == "n")
                        {
                            break;
                        }

                }

            catch (InputException ex)
            {
                Console.WriteLine(ex.Message);
            }

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




        }
    }
}
