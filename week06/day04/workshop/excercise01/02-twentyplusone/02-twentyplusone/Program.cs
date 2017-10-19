﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_twentyplusone
{
    class Program
    {

        static void Main(string[] args)
        {
            Deck deck = new Deck();

            List<Card> yourCards = new List<Card>();
            List<Card> othersCards = new List<Card>();
            yourCards.Add(deck.PullFirst());
            yourCards.Add(deck.PullFirst());
            othersCards.Add(deck.PullFirst());
            othersCards.Add(deck.PullFirst());

            Console.WriteLine("Your sum of cards: " + Game.Sum(yourCards));
            if (Game.Sum(yourCards) > 20)
            {
                Game.youStop = true;
                Console.WriteLine("Now you can't draw from the deck.");
            }

            while (!(Game.youStop && Game.otherStops))
            {
                if (!Game.youStop)
                {
                    Game.Continue(yourCards, deck);
                    if (Game.Sum(yourCards) > 20)
                    {
                        Game.youStop = true;
                        Console.WriteLine("Now you can't draw from the deck.");
                    }
                }
                Game.OpponentPlays(othersCards, deck);
            }
            Game.End(yourCards, othersCards);

            Console.ReadLine();
        }
    }
}