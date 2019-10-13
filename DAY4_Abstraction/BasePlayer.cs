using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public abstract class BasePlayer : IPlayer ///gives a base properties for a player, creates constructor of a player
                                               ///provides methods to GetName, GuessNumber and a bool value if the current number is guessed
    {
        public string Name;
        protected int CurrentGuess;
        protected int NextGuess;


        public BasePlayer()  /// 1. Constructor that sets ‘Name’ as GetName() returned string
        {
          
            Name = GetName();
        }

        
        public abstract string GetName(); /// abstract method to guess to read an assigned name for a player, returns a string 
                                          

        // 1. Abstract method without body.
        public abstract int GuessNumber();/// abstract method to guess the number, returns int GuessNumber
        

        public virtual bool IsNumberGuessed(int number)/// Checks and returns bool result if ‘number’ is equal ‘CurrentGuess’
        {
            
            if (number > CurrentGuess)
            {
                Console.WriteLine("{0} is less than number", CurrentGuess);
                NextGuess = 1;
            }
            else if (number < CurrentGuess)
            {
                Console.WriteLine("{0} is greater than number", CurrentGuess);
                NextGuess = -1;
            }
            return number == CurrentGuess;
        }

    }
}