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

            List<List<Card>> yourCards = new List<List<Card>>();
            yourCards.Add(new List<Card>());
            List<List<Card>> othersCards = new List<List<Card>>();
            othersCards.Add(new List<Card>());
            yourCards[0].Add(deck.PullFirst());
            yourCards[0].Add(deck.PullFirst());
            othersCards[0].Add(deck.PullFirst());
            othersCards[0].Add(deck.PullFirst());

            Console.WriteLine("Your sum of cards: " + Game.Sum(yourCards[0]));

            if (Game.Sum(yourCards[0]) == 21)
            {
                Game.youStop = true;
                Console.WriteLine("Now you can't draw from the deck.");
            }

            Game.IfSplit(yourCards);

            while (!(Game.youStop && Game.otherStops))
            {
                if (!Game.youStop)
                {
                    Game.Continue(yourCards, deck);
                    if ((yourCards.Count == 1 && Game.Sum(yourCards[0]) > 20) || (yourCards.Count == 2 && Game.Sum(yourCards[0]) > 20 && Game.Sum(yourCards[1]) > 20))
                    {
                        Game.youStop = true;
                        Console.WriteLine("Now you can't draw from the deck.");
                    }
                }
                Game.OpponentPlays(othersCards, deck);
            }

            if (yourCards.Count == 2 && othersCards.Count == 2)
            {
                Game.End(Game.End(yourCards[0], yourCards[1], false), Game.End(othersCards[0], othersCards[1], false), true);
            }
            else if (yourCards.Count == 2 && othersCards.Count == 1)
            {
                Game.End(Game.End(yourCards[0], yourCards[1], false), othersCards[0], true);
            }
            else if (yourCards.Count == 1 && othersCards.Count == 2)
            {
                Game.End(yourCards[0], Game.End(othersCards[0], othersCards[1], false), true);
            }
            else
            {
                Game.End(yourCards[0], othersCards[0], true);
            }

            Console.ReadLine();
        }
    }
}
