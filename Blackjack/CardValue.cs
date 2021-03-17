using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    //The numerical value of the card, in text and number format. If the name is Ace isAce should be true.
    class CardValue
    {
        private string name;
        private int value;
        private bool isAce;

        public CardValue(string name, int value)
        {
            this.name = name;
            this.value = value;
            this.isAce = name.ToLower() == "Ace";
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }
        }

        public bool IsAce
        {
            get
            {
                return isAce;
            }
        }
    }
}
