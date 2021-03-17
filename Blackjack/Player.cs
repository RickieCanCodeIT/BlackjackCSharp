using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    //A blackjack player, either the user or the dealer.
    class Player
    {
        private string name;
        private List<Card> hand;

        public Player(string name, List<Card> hand)
        {
            this.name = name;
            this.hand = hand;
        }

        public Card GetSpecificCard(int index)
        {
            return hand[index];
        }

        public int HandSize
        {
            get
            {
                return hand.Count;
            }
        }

        public void AddCardToHand(Card inCard)
        {
            hand.Add(inCard);
        }

        public int GetHandValue()
        {
            int handValue = 0;
            foreach (Card tempCard in hand)
            {
                if (!tempCard.CardValue.IsAce)
                {
                    handValue += tempCard.CardValue.Value;
                }
            }
            foreach (Card tempCard in hand)
            {
                if (tempCard.CardValue.IsAce && handValue <= 10)
                {
                    handValue += tempCard.CardValue.Value;
                }
                else if (tempCard.CardValue.IsAce)
                {
                    handValue += 1;
                }
            }
            return handValue;
        }

    public override string ToString()
        {
            string handString = "Your hand is:\n";
            foreach (Card tempCard in hand)
            {
                handString += tempCard.ToString() + "\n";
            }
            handString += "Your hand is currently worth " + GetHandValue() + " points.";
            return handString;
        }
    }
}
