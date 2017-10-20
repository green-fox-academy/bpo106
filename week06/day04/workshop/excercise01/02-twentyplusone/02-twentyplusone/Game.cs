using System;
using System.Collections.Generic;
using System.Linq;

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

        public static void IfSplit(List<List<Card>> cards)
        {
            if (cards[0][0].colorSuitRank[2] == cards[0][1].colorSuitRank[2])
            {
                Console.WriteLine("You have two identical valued cards. Do you want to split? (Y/N)");
                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    Split(cards);
                    Console.WriteLine("You splitted the cards in two hands.\nYour new sum of cards in each hand: {0} and {1}.", Sum(cards[0]), Sum(cards[1]));
                }
                else if (input.ToLower() != "n")
                {
                    Console.WriteLine("Wrong character, dude.");
                    IfSplit(cards);
                }
            }
        }

        public static void Split(List<List<Card>> cards)
        {
            cards.Add(new List<Card>());
            cards[1].Add(cards[0][1]);
            cards[0].RemoveAt(1);
        }

        public static void Continue(List<List<Card>> yourCards, Deck deck)
        {
            Console.WriteLine("Do you want to continue? (Y/N)");
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
            {
                if ((yourCards.Count == 2 && (Sum(yourCards[0]) > 14 || Sum(yourCards[1]) > 14)) || (yourCards.Count == 1 && Sum(yourCards[0]) > 14))
                {
                    youStop = true;
                    Console.WriteLine("You won't touch this deck anymore.");
                    return;
                }
                else
                {
                    for (int i = 0; i < yourCards.Count; i++)
                    {
                        ContinueElement(yourCards[i], deck, input);
                    }
                }
            }
            else if (input.ToLower() != "y")
            {
                Console.WriteLine("Wrong character, dude.");
                Continue(yourCards, deck);
            }
            else
            {
                for (int i = 0; i < yourCards.Count; i++)
                {
                    if (Sum(yourCards[i]) < 21)
                    {
                        ContinueElement(yourCards[i], deck, input);
                    }
                }
            }
        }

        public static void ContinueElement(List<Card> list, Deck deck, string input)
        {
            if (Sum(list) < 15 && input == "n")
            {
                Console.WriteLine("You need to draw more.");
            }
            list.Add(deck.PullFirst());
            Console.WriteLine("You drew {0}.\nYour new sum of cards: {1}.", list[list.Count - 1].colorSuitRank[2], Sum(list));
        }

        public static void OpponentPlays(List<List<Card>> othersCards, Deck deck)
        {
            int validSum;
            if (othersCards.Count == 1)
            {
                validSum = Sum(othersCards[0]);
            }
            else
            {
                validSum = Math.Max(Sum(othersCards[0]), Sum(othersCards[1]));
            }
            if (random.Next(15, 20) < validSum)
            {
                otherStops = true;
                Console.WriteLine("The dealer finished drawing until the end.");
            }
            else
            {
                othersCards[0].Add(deck.PullFirst());
                if (othersCards.Count == 2)
                {
                    othersCards[1].Add(deck.PullFirst());
                }
                Console.WriteLine("The dealer drew a card.");
            }
        }

        public static List<Card> End (List<Card> yourCards, List<Card> othersCards, bool hasToWrite)
        {
            if (hasToWrite)
            {
                Console.WriteLine("\nThe game has ended.\nYour sum of cards: {0}.\nThe dealer's sum of cards: {1}.", Sum(yourCards), Sum(othersCards));
            }

            if (Sum(yourCards) > 21)
            {
                if (Sum(othersCards) < 22)
                {
                    if (hasToWrite)
                    {
                        Console.WriteLine("The dealer won.");
                    }
                    return othersCards;
                }
                else if (Sum(yourCards) < Sum(othersCards))
                {
                    if (hasToWrite)
                    {
                        Console.WriteLine("You won.");
                    }
                    return yourCards;
                }
                else if (Sum(yourCards) > Sum(othersCards))
                {
                    if (hasToWrite)
                    {
                        Console.WriteLine("The dealer won.");
                    }
                    return othersCards;
                }
                else
                {
                    if (hasToWrite)
                    {
                        Console.WriteLine("Draw.");
                    }
                    return yourCards;
                }
            }
            else
            {
                if (Sum(othersCards) > 21)
                {
                    if (hasToWrite)
                    {
                        Console.WriteLine("You won.");
                    }
                    return yourCards;
                }
                else if (Sum(yourCards) > Sum(othersCards))
                {
                    if (hasToWrite)
                    {
                        Console.WriteLine("You won.");
                    }
                    return yourCards;
                }
                else if (Sum(yourCards) < Sum(othersCards))
                {
                    if (hasToWrite)
                    {
                        Console.WriteLine("The dealer won.");
                    }
                    return othersCards;
                }
                else
                {
                    if (hasToWrite)
                    {
                        Console.WriteLine("Draw.");
                    }
                    return yourCards;
                }
            }
        }
    }
}
