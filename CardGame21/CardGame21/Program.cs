using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame21
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            deck1.Shuffle();
            Console.WriteLine("Do you want a card dealt to you? (y/n)");
            var userInput = Console.ReadLine();
            while (true)
            {
                if (userInput.ToLower() == "y")
                {
                    Console.WriteLine("Your card is: {0}", deck1.DealCard());
                    continue;
                }
                else
                    Console.WriteLine("Goodbye");
                break;
            }
            //for (int i = 0; i < 52; i++)
            //{
            //    Console.Write("{0, -20}", deck1.DealCard());
            //    //dealing cards to the number of players (%n) n = the number of players
            //    if ((i + 1) % 4 == 0)
            //        Console.WriteLine();
            //}
            Console.Read();
        }
    }
}
