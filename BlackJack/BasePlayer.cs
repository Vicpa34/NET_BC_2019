using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public abstract class BasePlayer : IBlackJackPlayer
    {
        protected string Name { get; set; }

        protected List<Card> Cards { get; set;}

        public BasePlayer()
        {
            Cards = new List<Card>();
            Name = GetName();
        }
        // Returns player`s card in hands
        public List<Card> GetCards()
        {
            return Cards;
        }

        //counts total points of pleyer`s cards
        //if total points is over 21 and player has ACE
        //remove 10 poinrs for each ACE untill points <=21
        //or there are no more aces

        public int CountPoints()
        {
            int points = Cards.Sum(c => c.GetPoints());
            //int points = 0;
            //foreach (Card card in Cards)
            //{
            //    points += card.GetPoints();
            //}
            //return points;
            if (points > 21)
            {
                int aceCount = Cards.Count(c => c.GetPoints() == 11);
                while (aceCount > 0 && points > 21)
                {
                    points = points - 10;
                    aceCount--;
                }
            }

            return points;
            
        }

        //returns true if player`s points  is over 21, otherwise false
        public bool IsGameCompleted()
        {
            return CountPoints() > 21;
           
        }

        //player receives a new card from the deck.
        //add card to player`s hand
        public void GiveCard(Card card)
        {
            Cards.Add(card);
        }
        public abstract string GetName();
        public abstract bool WantCard();
    }
}
