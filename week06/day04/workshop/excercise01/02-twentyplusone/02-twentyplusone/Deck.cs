using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_twentyplusone
{
    public class Deck
    {
        List<Card> list = new List<Card>();

        public Deck()
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int rank = 2; rank < 15; rank++)
                {
                    list.Add(new Card((suit * (suit % 3)) % 3, suit, rank));
                }
            }
            ShuffleDeck();
        }

        public void ShuffleDeck()
        {
            Random random = new Random();
            list = list.OrderBy(x => random.Next()).Select(x => x).ToList();
        }
        public Card PullFirst()
        {
            Card card = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return card;
        }
    }
}
