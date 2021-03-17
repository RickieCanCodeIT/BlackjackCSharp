using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    //A card in the standard 52 card deck
    class Card
    {
        private CardValue cardValue;
        private Suit suit;

        public Card(CardValue cardValue, Suit suit)
        {
            this.cardValue = cardValue;
            this.suit = suit;
        }

        public CardValue CardValue
        {
            get
            {
                return cardValue;
            }
        }

        public Suit Suit
        {
            get
            {
                return suit;
            }
        }

        public override string ToString()
        {
            return cardValue.Name + " of " + suit.Name;
        }
    }
}
