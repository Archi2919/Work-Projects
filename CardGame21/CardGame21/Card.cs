using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame21
{
    public class Card
    {
        //Face = Ace, two, three, four, etc
        private string face;
        //Suit = Diamonds, Spades, etc
        private string suit;

        //Constructor
        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }

        //Provide our own to string function
        public override string ToString()
        {
            return face + " of " + suit;
        }
    }
}
