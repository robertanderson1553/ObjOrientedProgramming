using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLibrary;

namespace PokerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance of CardSet class
            CardSet myDeck = new CardSet();

            // loop that writes 52 unique cards to the console.
            for (int i = 1; i < 53; i++)
            {
                Console.WriteLine(myDeck.CardArray[i].CardRank + " of " + myDeck.CardArray[i].CardSuit);
            }

            // end of program

            Console.ReadLine();

        }
    }
}
