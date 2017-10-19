using System;
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

            while(Game.Sum(yourCards) < 21 && Game.Sum(othersCards) < 21 && !Game.hasToStop)
            {
                Game.Continue();
                if (Game.hasToStop)
                {
                    continue;
                }

            }

            Console.ReadLine();
        }
    }
}
