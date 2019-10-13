using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAY4_ABSTRACTION
{
    public class User : BasePlayer ///a class for player User inheriting from the BasePlayer, 
    {
       
        public override string GetName()  ///asks User to enter his name, returns string
        {
            if (!String.IsNullOrEmpty(Name))
            {
                return Name;
            }
            return ConsoleInput.GetText("Enter your name: ");
        }

       
        public override int GuessNumber()   ///asks user to enter a number, returns entered number
        {
            CurrentGuess = ConsoleInput.GetInt("Enter your guess: ");
            return CurrentGuess;
            //CurrentNumber = new Random().Next(1, 501);

            ////2.Return generated number.
            //return CurrentGuess;

        }
    }
}