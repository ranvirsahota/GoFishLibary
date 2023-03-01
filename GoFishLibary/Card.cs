using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFishLibary
{
    internal class Card
    {
        public Card(string suit, int value) { Suit = suit; Value = value; }
        public string Suit { get; }
        public int Value { get; }

    }
}
