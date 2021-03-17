using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    //A deck of cards
    class Deck
    {
        private List<Card> cards;
        private static Random random = new Random(); 

        public Deck()
        {
            MakeFreshDeck();
        }

        //Makes a brand new deck with 52 cards, 13 cards of each suit.
        //The four suits are Spades, Clubs, Hearts, and Diamonds.
        //The 13 cards are Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
        public void MakeFreshDeck()
        {
            cards = new List<Card>();
            Suit[] suits = { new Suit("Spades", 'S'), new Suit("Clubs", 'C'),
                new Suit("Hearts", 'H'), new Suit("Diamonds", 'D')};
            CardValue[] cardValues = { new CardValue("One", 1), new CardValue("Two", 2),
                new CardValue("Three", 3),new CardValue("Four", 4), new CardValue("Five", 5),
                new CardValue("Six", 6), new CardValue("Seven", 7), new CardValue("Eight", 8),
                new CardValue("Nine", 9), new CardValue("Ten", 10), new CardValue("Jack", 10),
                new CardValue("Queen", 10), new CardValue("King", 10), new CardValue("Ace", 11)};
            foreach (Suit tempSuit in suits)
            {
                foreach (CardValue tempCardValue in cardValues)
                {
                    cards.Add(new Card(tempCardValue, tempSuit));
                }
            }
            Shuffle();
        }

        //shuffle the deck
        public void Shuffle()
        {
            for (int counter = 0; counter < 5; counter++)
            {
                List<Card> tempCardList = new List<Card>();
                while (cards.Count > 0)
                {
                    int cardIndex = random.Next(0, cards.Count);
                    Card tempCard = cards[cardIndex];
                    cards.RemoveAt(cardIndex);
                    tempCardList.Add(tempCard);
                }
                cards = tempCardList;
            }

        }

        //draw a card from the deck, refresh the deck if out of cards.
        public Card DrawCard()
        {
            Card returnCard = cards[0];
            cards.RemoveAt(0);
            return returnCard;
        }
    }
}
