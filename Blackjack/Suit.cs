using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Suit
    {
        private string name;
        private char suitCode;

        public Suit(string name, char suitCode)
        {
            this.name = name;
            this.suitCode = suitCode;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public char SuitCode
        {
            get
            {
                return suitCode;
            }
        }
    }
}
