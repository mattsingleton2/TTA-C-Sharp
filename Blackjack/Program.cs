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
            int timesShuffled = 0;
            deck = Shuffle(deck: deck, out timesShuffled, times: 3);

            //  Used to check out our deck to make sure our constructor worked.
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count + " total cards in the deck.");
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
            
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();

                //  Instantiate the Random object! 
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }
    }
}
