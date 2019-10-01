using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = GetNumber("Enter number A: ");
                int num2 = GetNumber("Enter number B: ");


                Console.WriteLine("Division = {0}",
                Calculator.Divide(num1, num2));
            }
            catch (Exception)
            {
                Console.WriteLine("Neparedzeta kluda");
            }


            Console.Read();
        }
        static int GetNumber(string text)
        {
            
            Console.Write(text);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }

            try
            {
                int result = int.Parse(input);
                return result;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
                GetNumber(text);  //recursion - call out function where we are
            }
        }
    }
}
