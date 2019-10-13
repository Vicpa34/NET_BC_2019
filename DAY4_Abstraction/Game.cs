using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public class Game   ///combines fields and methods for a Game
    {
        private int CurrentNumber;  
        private IPlayer PlayerOne;  
        private IPlayer PlayerTwo; 

        public int StartNewGame() ///method generates a new number and sets it as "current number", 
                                  ///creates PlayerOne and PlayerTwo, setting them as "User" and "Robot"
                                  ///returns an integer of a random "current number"
        {
            //1. generate a new random number (1-500) and set it as "current number"
            CurrentNumber = new Random().Next(1, 501);
            //2. Create PlayerOne and PlayerTwo:
            // 2.1 PlayerOne as User;
            PlayerOne = new User();
            // 2.2 PlayerTwo as Robot
            PlayerTwo = new Robot();

            //2.Return generated number.
            return CurrentNumber;
            // generates new random number
        }

        public void Loop() ///main game loop which contains PlayerOne turn and then PlayerTwo turn
        {

                while (true)
            {
                if (PlayerTurn(PlayerOne))
                {
                    break;
                }
                if (PlayerTurn(PlayerTwo))
                {
                    break;
                }
                ////1.1 PlayerOne guesse the number
                //PlayerOne.GuessNumber();
                ////if guess is correct break the loop and PlayerOne wins
                //if (PlayerOne.IsNumberGuessed(CurrentNumber))
                //{
                //    Console.WriteLine("PlayerOne wins!");
                //    break;
                //}
                ////1.2 PlayerTwo guesses the number:
                //PlayerTwo.GuessNumber();
                ////1.2.1 if guess is correct break the loop and PlayerTwo wins
                //if (PlayerTwo.IsNumberGuessed(CurrentNumber))
                //{
                //    Console.WriteLine("Player two wins!");
                //    break;
                //}
            }
        }

        public bool PlayerTurn(IPlayer player) ///a method checking if the guessed number and a number entered by the player coincide  
                                               ///returns a bool value
        {
            player.GuessNumber();
            bool isGuessed = player.IsNumberGuessed(CurrentNumber);

            if (isGuessed)
            {
                Console.WriteLine("Player {0} wins!", player.GetName());
            }
            return isGuessed;
        }
    }
}