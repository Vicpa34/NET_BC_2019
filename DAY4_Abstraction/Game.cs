using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_Abstraction
{
    class Game
    {
        int CurrentNumber;
        IPlayer PlayerOne { get; set; }
        IPlayer PlayerTwo { get; set; }



        public void StartNewGame()
        { 
        }

        public void Loop()
        {
        }

        public void PlayerTurn(IPlayer player)
        { 
        }
    }
}
