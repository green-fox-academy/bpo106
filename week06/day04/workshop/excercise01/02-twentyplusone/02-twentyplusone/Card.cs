using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_twentyplusone
{
    enum Color
    {
        red,
        black
    }

    enum Suit
    {
        clubs,
        diamonds,
        hearts,
        spades
    }

    enum Rank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public class Card
    {
        public int[] colorSuitRank = new int[3];

        public Card(int color, int suit, int rank)
        {
            colorSuitRank[0] = color;
            colorSuitRank[1] = suit;
            colorSuitRank[2] = rank;
        }
    }
}
