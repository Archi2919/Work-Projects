using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame21
{
    public class Deck
    {
        //to hold all 52 cards
        private Card[] deck;
        //to keep track of where we are in the array of cards
        private int currentCard;
        private const int Number_Of_Cards = 52;
        private Random ranNum;

        public Deck()
        {
            string[] faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
                                "Ten", "Jack", "Queen", "King"};
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades"};

            deck = new Card[Number_Of_Cards];
            currentCard = 0;
            ranNum = new Random();

            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }

        public void Shuffle()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = ranNum.Next(Number_Of_Cards);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public Card DealCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
                Console.WriteLine("The deck is empty");
                return null;
        }
    }
}