using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public interface IBlackJackPlayer
    {
        //returns Player`s name
        string GetName();

        //returns player`s cards in hand
        List<Card> GetCards();

        //counts total points of player`s cards
        int CountPoints();

        //checks if player`s points is over 21
        bool IsGameCompleted();

        //checks if player wants another card
        bool WantCard();

        //player receives a new card from the deck. Adds card to a player
        void GiveCard(Card card);
     


    }
}
