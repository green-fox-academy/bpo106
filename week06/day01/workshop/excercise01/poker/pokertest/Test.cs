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

        [Test]
        public void Test01()
        {
            Hand hand = new Hand();
            List<int[]> hand1 = new List<int[]>() { new int[] { 2, 3, 0 }, new int[] { 3, 2, 0 }, new int[] { 5, 4, 0 }, new int[] { 9, 1, 0 }, new int[] { 12, 2, 0 } };
            List<int[]> hand2 = new List<int[]>() { new int[] { 2, 1, 0 }, new int[] { 3, 3, 0 }, new int[] { 4, 4, 0 }, new int[] { 8, 1, 0 }, new int[] { 13, 3, 0 } };

            Assert.AreEqual(-1, hand.Game(hand1, hand2));
        }

        [Test]
        public void Test02()
        {
            Hand hand = new Hand();
            List<int[]> hand1 = new List<int[]>() { new int[] { 2, 3, 0 }, new int[] { 3, 2, 0 }, new int[] { 5, 4, 0 }, new int[] { 9, 1, 0 }, new int[] { 13, 2, 0 } };
            List<int[]> hand2 = new List<int[]>() { new int[] { 2, 1, 0 }, new int[] { 3, 3, 0 }, new int[] { 4, 4, 0 }, new int[] { 8, 1, 0 }, new int[] { 13, 3, 0 } };

            Assert.AreEqual(1, hand.Game(hand1, hand2));
        }

        [Test]
        public void Test03()
        {
            Hand hand = new Hand();
            List<int[]> hand1 = new List<int[]>() { new int[] { 2, 3, 0 }, new int[] { 3, 2, 0 }, new int[] { 9, 1, 0 }, new int[] { 13, 2, 0 }, new int[] { 5, 4, 0 } };
            List<int[]> hand2 = new List<int[]>() { new int[] { 2, 1, 0 }, new int[] { 3, 3, 0 }, new int[] { 4, 4, 0 }, new int[] { 8, 1, 0 }, new int[] { 13, 3, 0 } };

            Assert.AreEqual(1, hand.Game(hand1, hand2));
        }
    }
}
