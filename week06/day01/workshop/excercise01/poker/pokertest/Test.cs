using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using poker;

namespace pokertest
{
    [TestFixture]
    public class Test
    {
        // Első nyer: 1, második nyer: -1, döntetlen: 0

        // Kombináció nélküli kéz: 0
        // Pár: 1
        // Két pár: 2
        // Drill: 3
        // stb. stb.

        [Test]
        public void HighCardTest01()
        {
            Hand hand = new Hand();
            List<int[]> hand1 = new List<int[]>() { new int[] { 2, 3, 0 }, new int[] { 3, 2, 0 }, new int[] { 5, 4, 0 }, new int[] { 9, 1, 0 }, new int[] { 12, 2, 0 } };
            List<int[]> hand2 = new List<int[]>() { new int[] { 2, 1, 0 }, new int[] { 3, 3, 0 }, new int[] { 4, 4, 0 }, new int[] { 8, 1, 0 }, new int[] { 13, 3, 0 } };

            Assert.AreEqual(-1, hand.Game(hand1, hand2));
        }

        [Test]
        public void HighCardTest02()
        {
            Hand hand = new Hand();
            List<int[]> hand1 = new List<int[]>() { new int[] { 2, 3, 0 }, new int[] { 3, 2, 0 }, new int[] { 5, 4, 0 }, new int[] { 9, 1, 0 }, new int[] { 13, 2, 0 } };
            List<int[]> hand2 = new List<int[]>() { new int[] { 2, 1, 0 }, new int[] { 3, 3, 0 }, new int[] { 4, 4, 0 }, new int[] { 8, 1, 0 }, new int[] { 13, 3, 0 } };

            Assert.AreEqual(1, hand.Game(hand1, hand2));
        }

        [Test]
        public void HighCardTest03()
        {
            Hand hand = new Hand();
            List<int[]> hand1 = new List<int[]>() { new int[] { 2, 3, 0 }, new int[] { 3, 2, 0 }, new int[] { 9, 1, 0 }, new int[] { 13, 2, 0 }, new int[] { 5, 4, 0 } };
            List<int[]> hand2 = new List<int[]>() { new int[] { 2, 1, 0 }, new int[] { 3, 3, 0 }, new int[] { 4, 4, 0 }, new int[] { 8, 1, 0 }, new int[] { 13, 3, 0 } };

            Assert.AreEqual(1, hand.Game(hand1, hand2));
        }

        [Test]
        public void OnePairTest()
        {
            Hand hand = new Hand();
            List<int[]> hand1 = new List<int[]>() { new int[] { 2, 3, 0 }, new int[] { 3, 2, 0 }, new int[] { 9, 1, 0 }, new int[] { 5, 2, 0 }, new int[] { 5, 4, 0 } };
            List<int[]> hand2 = new List<int[]>() { new int[] { 2, 1, 0 }, new int[] { 3, 3, 0 }, new int[] { 4, 4, 0 }, new int[] { 8, 1, 0 }, new int[] { 13, 3, 0 } };

            Assert.AreEqual(1, hand.Game(hand1, hand2));
        }

        [Test]
        public void ThreeOfAKindTest()
        {
            Hand hand = new Hand();
            List<int[]> hand1 = new List<int[]>() { new int[] { 2, 3, 0 }, new int[] { 3, 2, 0 }, new int[] { 5, 1, 0 }, new int[] { 5, 2, 0 }, new int[] { 5, 4, 0 } };
            List<int[]> hand2 = new List<int[]>() { new int[] { 2, 1, 0 }, new int[] { 3, 3, 0 }, new int[] { 4, 4, 0 }, new int[] { 8, 1, 0 }, new int[] { 13, 3, 0 } };

            Assert.AreEqual(1, hand.Game(hand1, hand2));
            Assert.AreEqual(3, hand.Combination(hand.Convert(hand1)));
        }

        [Test]
        public void PokerAndTwoPairsTest()
        {
            Hand hand = new Hand();
            List<int[]> hand1 = new List<int[]>() { new int[] { 2, 3, 0 }, new int[] { 9, 2, 0 }, new int[] { 9, 1, 0 }, new int[] { 5, 2, 0 }, new int[] { 5, 4, 0 } };
            List<int[]> hand2 = new List<int[]>() { new int[] { 6, 1, 0 }, new int[] { 6, 3, 0 }, new int[] { 6, 4, 0 }, new int[] { 6, 2, 0 }, new int[] { 3, 3, 0 } };

            Assert.AreEqual(-1, hand.Game(hand1, hand2));
            Assert.AreEqual(2, hand.Combination(hand.Convert(hand1)));
            Assert.AreEqual(7, hand.Combination(hand.Convert(hand2)));
        }

        [Test]
        public void FullHouseTest()
        {
            Hand hand = new Hand();
            List<int[]> hand1 = new List<int[]>() { new int[] { 3, 3, 0 }, new int[] { 3, 2, 0 }, new int[] { 5, 1, 0 }, new int[] { 5, 2, 0 }, new int[] { 5, 4, 0 } };
            List<int[]> hand2 = new List<int[]>() { new int[] { 2, 1, 0 }, new int[] { 7, 3, 0 }, new int[] { 4, 4, 0 }, new int[] { 8, 1, 0 }, new int[] { 13, 3, 0 } };

            Assert.AreEqual(1, hand.Game(hand1, hand2));
            Assert.AreEqual(6, hand.Combination(hand.Convert(hand1)));
            Assert.AreEqual(0, hand.Combination(hand.Convert(hand2)));
        }

        [Test]
        public void StraightTest()
        {
            Hand hand = new Hand();
            List<int[]> hand1 = new List<int[]>() { new int[] { 4, 3, 0 }, new int[] { 8, 2, 0 }, new int[] { 5, 1, 0 }, new int[] { 6, 2, 0 }, new int[] { 7, 4, 0 } };
            List<int[]> hand2 = new List<int[]>() { new int[] { 2, 1, 0 }, new int[] { 3, 3, 0 }, new int[] { 4, 4, 0 }, new int[] { 8, 1, 0 }, new int[] { 13, 3, 0 } };

            Assert.AreEqual(1, hand.Game(hand1, hand2));
            Assert.AreEqual(4, hand.Combination(hand.Convert(hand1)));
        }

        [Test]
        public void FlushAndStraightTest()
        {
            Hand hand = new Hand();
            List<int[]> hand1 = new List<int[]>() { new int[] { 4, 3, 0 }, new int[] { 8, 2, 0 }, new int[] { 5, 1, 0 }, new int[] { 6, 2, 0 }, new int[] { 7, 4, 0 } };
            List<int[]> hand2 = new List<int[]>() { new int[] { 2, 1, 0 }, new int[] { 3, 1, 0 }, new int[] { 9, 1, 0 }, new int[] { 10, 1, 0 }, new int[] { 11, 1, 0 } };

            Assert.AreEqual(-1, hand.Game(hand1, hand2));
            Assert.AreEqual(4, hand.Combination(hand.Convert(hand1)));
            Assert.AreEqual(5, hand.Combination(hand.Convert(hand2)));
        }
    }
}