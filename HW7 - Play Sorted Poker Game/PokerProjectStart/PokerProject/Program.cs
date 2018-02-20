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
            int howManyCards = 10;      // number of cards for each player
            int balance = 10;          // amount of money each player has to begin game
            int eachBet = 1;           // amount of each bet
            
            //Set color
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            // instance of CardSet class
            CardSet myDeck = new CardSet();

            // Game Introduction message
            Console.WriteLine("Welcome to the Poker Game.");
            Console.WriteLine("You have ${0}.00 and each bet will be ${1}.00.", balance, eachBet);
            Console.WriteLine("Press any key when you are ready to start.");
            Console.ReadKey();
           
            // Play game while you have money (until balance is zero)
            while (balance > 0)
            {
                // Create a 'hand' (an array of n cards), for both the computer and the player 
                SuperCard[] computerHand = myDeck.GetCards(howManyCards);
                SuperCard[] playersHand = myDeck.GetCards(howManyCards);

                // Display the cards sorted by Suit and then Rank
                Array.Sort(computerHand);
                Array.Sort(playersHand);

                // Display each players hand
                CardSet.DisplayHands(computerHand, playersHand);

                // for some reason command "Console.ResetColor();" does not reset the color??
                // Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                
                // Accumulte the card values for each player to see who won
                bool won = CardSet.CompareHands(computerHand, playersHand);
                if (won)     //won hand
                {
                    Console.WriteLine("\nYou won.");
                    balance++;
                }
                else         // lost hand
                {
                    Console.WriteLine("\nYou lost.");
                    balance--;
                }

                // Display game progress from the players point of view
                Console.WriteLine("You have ${0}.00. Press [Enter] key for another hand or [q] to quit.", balance);

                // Quit playing game when user enters [q] to Quit
                ConsoleKeyInfo result = Console.ReadKey();
                if ((result.KeyChar == 'Q') || (result.KeyChar == 'q')) { break; }
            }

           // end of program

            Console.ReadLine();

        }
    }
}
