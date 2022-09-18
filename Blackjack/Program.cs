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
            //deck.shuffle();

            ////  used to check out our deck to make sure our constructor worked.
            //foreach (card card in deck.cards)
            //{
            //    console.writeline(card.face + " of " + card.suit);
            //}
            //console.writeline(deck.cards.count + " total cards in the deck.");
            //console.readline();

        }


    }
}
