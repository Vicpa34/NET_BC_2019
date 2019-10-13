using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION 
    /// interface that contains basic functionality of a player>
                          
{
    public interface IPlayer
    {
        int GuessNumber(); /// a method for guessing a number on a Player`s part
                           /// returns an integer
        
        bool IsNumberGuessed(int number); /// a method for deinition of whether the number is guessed
                                          /// returna a bool value
       
        string GetName();  /// a method for reading of a Player`s name
                           /// returns a string
    }
}