using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public class Robot : BasePlayer ///a class for player Robot inheriting from the BasePlayer, 
    {
        public override string GetName() ///defines the name for a player ROBOT, returns string
        {
            //1. Returns text “R0B0T”.
            return "R0B0T";
        }

        public override int GuessNumber() ///Generates random number from 1 to 500 and store it as ‘CurrentGuess’, returns integer
        {
            //
            if (NextGuess == 0)
            {
                CurrentGuess = new Random().Next(1, 501);
            }
            else if (NextGuess == -1)
            {
                CurrentGuess = new Random().Next(1, CurrentGuess);
            }
            else if (NextGuess == 1)
            {
                CurrentGuess = new Random().Next(CurrentGuess +1, 501);
            }

            //2.Return generated number.
            return CurrentGuess;
        }
    }
}