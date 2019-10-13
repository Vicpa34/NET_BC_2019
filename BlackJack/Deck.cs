using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        //4 masti
        string[] suits = new[] { "C", "S", "D", "H" };
        //13 rangi
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        List<Card> Cards;

        //creates a new list of cards (List<Card>).
        //Fills List with all 52 cards (4 suits and 13 ranks)

        public Deck()
        {
            Cards = new List<Card>();
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Cards.Add(new Card(rank, suit));
                }
            }
        }

        // Randomly orders (shuffles) the list of cards

        public void Shuffle()
        {
            Random rnd = new Random();
            Cards = Cards.OrderBy(c => rnd.Next()).ToList();
        }

        //takes the last card form the list
        //removes it from the list
        //returns it

        public Card GetCard()
        {
            Card card = Cards.Last();
            Cards.Remove(card);

            return card;
        }
    }
}
