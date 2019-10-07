using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_Abstraction
{
    abstract class AbstractClassBasePlayer : IPlayer
    {
        public int GuessNumber()
        {
            throw new NotImplementedException();
        }

        string Name;
        int CurrentGuess;

        public bool IsNumberGuessed(int number);
        {
          return false;
        }

        public abstract string GetName();
         {

         }
    }
}

