using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Program
    {
        static void Main()
        {
            //  Instantiate our deck..
            Deck deck = new Deck();
            deck.Shuffle();

            //  Used to check out our deck to make sure our constructor worked.
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count + " total cards in the deck.");
            Console.ReadLine();
            
        }

       
    }
}
