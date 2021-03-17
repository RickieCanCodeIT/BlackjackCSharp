using System;
using System.Collections.Generic;

namespace Blackjack
{
    //A blackjack application. Beat the dealer's hand or lose. Look up Blackjack rules for more description.
    //Nothing in this file is broken.
    class Program
    {
        public static Deck currentDeck;
        public static Player dealer;
        public static Player user;

        static void Main(string[] args)
        {
            currentDeck = new Deck();
            string playAgain;
            do
            {
                dealer = new Player("Dealer", new List<Card>());
                user = new Player("User", new List<Card>());
                user.AddCardToHand(currentDeck.DrawCard());
                dealer.AddCardToHand(currentDeck.DrawCard());
                user.AddCardToHand(currentDeck.DrawCard());
                dealer.AddCardToHand(currentDeck.DrawCard());
                string choice = "";
                while (choice.ToLower() != "stand" && user.GetHandValue() < 21)
                {
                    Console.WriteLine(user.ToString());
                    Console.WriteLine("The dealer's visible card is: " + dealer.GetSpecificCard(1));
                    Console.WriteLine("Do you want to Hit or Stand?");
                    choice = Console.ReadLine();
                    if (choice.ToLower() == "hit")
                    {
                        Card drawnCard = currentDeck.DrawCard();
                        user.AddCardToHand(drawnCard);
                        Console.WriteLine("You drew the " + drawnCard.ToString() + "!");
                        Console.WriteLine("Your hand is now worth " + user.GetHandValue() + " points.");
                    }
                }

                while (dealer.GetHandValue() < 17)
                {
                    dealer.AddCardToHand(currentDeck.DrawCard());
                }

                if (user.GetHandValue() == 21 && user.HandSize == 2)
                {
                    Console.WriteLine("Blackjack! You win big!");
                }
                else if (user.GetHandValue() > 21)
                {
                    Console.WriteLine("You bust! Try again next time!");
                }
                else if (user.GetHandValue() > dealer.GetHandValue())
                {
                    Console.WriteLine("The dealer had " + dealer.GetHandValue() + ". You win! Congratulations!");
                }
                else if (dealer.GetHandValue() <= 21)
                {
                    Console.WriteLine("The dealer had " + dealer.GetHandValue() + ". You lost...");
                }
                else
                {
                    Console.WriteLine("The dealer busts! You win!");
                }
                Console.WriteLine("Play again? (yes or no)");
                playAgain = Console.ReadLine();
            } while (playAgain.ToLower() =="yes");
        }
    }
}
