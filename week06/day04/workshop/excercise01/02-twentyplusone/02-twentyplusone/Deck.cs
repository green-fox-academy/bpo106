﻿using System;
using System.Collections.Generic;
using System.Linq;

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
                    int rankTemp = rank;
                    if (rank == 14)
                    {
                        rankTemp = 11;
                    }
                    else if (rank > 10)
                    {
                        rankTemp = 10;
                    }
                    list.Add(new Card((suit * (suit % 3)) % 3, suit, rankTemp));
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
