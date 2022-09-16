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

            //  Instantiate our game.
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Matt", "Frame", "Toad" };
            game.ListPlayers();
            Console.ReadLine();
            //  Instantiate our deck and shuffle it.
            //Deck deck = new Deck();
            //deck.Shuffle();

            ////  Used to check out our deck to make sure our constructor worked.
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count + " total cards in the deck.");
            //Console.ReadLine();
            
        }

       
    }
}
