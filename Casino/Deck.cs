using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
            //  Instantiating the List for our deck.
            Cards = new List<Card>();

            //  There are 13 possible faces (See Card.cs for that enum) so lets start our 13 loop...
            for (int i = 0; i < 13; i++)
            {
                //  And then we have 4 different suits (Again, in Card.cs that Enum is defined)
                for (int j = 0; j < 4; j++)
                {
                    //  Instantiate the card object, then...
                    Card card = new Card();

                    //  Give it a face. Here, we cast a Face type as 'i'. So for the first instance, it would go to the Face Enum and pull i = 0 , so the 0 index of the Faces enum.
                    card.Face = (Face)i;

                    //  Same thing, but with suits. So whatever is in the 0 enum for suits will be assigned in the first iteration.
                    card.Suit = (Suit)j;

                    //  Add the object to the Cards List we instantiated above.
                    Cards.Add(card);
                }
            }
            
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();

                //  Instantiate the Random object! 
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    //  Sets the range for the random number from 0 --> however many cards are still in our deck.
                    int randomIndex = random.Next(0, Cards.Count);

                    //  Takes a card at the random index and adds it to our temporary list (basically think about taking cards
                    //  one-by-one and building a new deck next to the old one.
                    TempList.Add(Cards[randomIndex]);

                    //  Remove that card that we added to the temp list from the old deck.
                    Cards.RemoveAt(randomIndex);
                }
                //  Use our temp list as our deck (copies that over.)
                Cards = TempList;
            }
        }
    }
}
