﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    class Program  ///starts execution of the program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartNewGame();
            game.Loop();

            Console.Read();
        }
    }
}