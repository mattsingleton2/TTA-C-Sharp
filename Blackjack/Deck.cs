﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck
    {
        public Deck()
        {
            //  Instantiating the List for our deck.
            Cards = new List<Card>();

            //  Setting up the possible suits and faces as lists.
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //  Iterates through the lists and creates a card object for each suit and face.
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card
                    {
                        Suit = suit,
                        Face = face
                    };
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}