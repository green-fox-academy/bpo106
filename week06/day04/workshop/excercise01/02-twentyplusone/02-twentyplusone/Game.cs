using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_twentyplusone
{
    public static class Game
    {
        public static bool youStop = false;
        public static bool otherStops = false;
        static Random random = new Random();

        public static int Sum(List<Card> list)
        {
            return list.Sum(x => x.colorSuitRank[2]);
        }

        public static void Continue(List<Card> yourCards, Deck deck)
        {
            Console.WriteLine("Do you want to continue? (Y/N)");
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
            {
                if (Sum(yourCards) > 14)
                {
                    youStop = true;
                    Console.WriteLine("You won't touch the deck anymore.");
                    return;
                }
                else
                {
                    Console.WriteLine("You need to draw more.");
                    yourCards.Add(deck.PullFirst());
                    Console.WriteLine("You drew {0}.\nYour new sum of cards: {1}.", yourCards[yourCards.Count - 1].colorSuitRank[2], Sum(yourCards));
                }
            }
            else if (input.ToLower() != "y")
            {
                Console.WriteLine("Wrong character, dude.");
                Continue(yourCards, deck);
            }
            else
            {
                yourCards.Add(deck.PullFirst());
                Console.WriteLine("You drew {0}.\nYour new sum of cards: {1}.", yourCards[yourCards.Count - 1].colorSuitRank[2], Sum(yourCards));
            }
        }

        public static void OpponentPlays(List<Card> othersCards, Deck deck)
        {
            if (random.Next(15, 20) < Sum(othersCards))
            {
                otherStops = true;
                Console.WriteLine("The other finished drawing until the end.");
            }
            else
            {
                othersCards.Add(deck.PullFirst());
                Console.WriteLine("The other drew a card.");
            }
        }

        public static void End (List<Card> yourCards, List<Card> othersCards)
        {
            Console.WriteLine("\nThe game has ended.\nYour sum of cards: {0}.\nOther's sum of cards: {1}.", Sum(yourCards), Sum(othersCards));

            if (Sum(yourCards) > 21)
            {
                if (Sum(othersCards) < 22)
                {
                    Console.WriteLine("The other won.");
                }
                else if (Sum(yourCards) < Sum(othersCards))
                {
                    Console.WriteLine("You won.");
                }
                else if (Sum(yourCards) > Sum(othersCards))
                {
                    Console.WriteLine("The other won.");
                }
                else
                {
                    Console.WriteLine("Draw.");
                }
            }
            else
            {
                if (Sum(othersCards) > 22)
                {
                    Console.WriteLine("You won.");
                }
                else if (Sum(yourCards) > Sum(othersCards))
                {
                    Console.WriteLine("You won.");
                }
                else if (Sum(yourCards) < Sum(othersCards))
                {
                    Console.WriteLine("The other won.");
                }
                else
                {
                    Console.WriteLine("Draw.");
                }
            }
        }
    }
}
