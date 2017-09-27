using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Anagram;

namespace AnagramTest
{
    [TestFixture]
    public class AnagramTest
    {
        [Test]
        public void AnagramEqualityTest()
        {
            Anagrams compare = new Anagrams();
            string word1 = "one plus twelve";
            string word2 = "two plus eleven";

            Assert.AreEqual(true, compare.wordCompare(word1, word2));
        }

        [Test]
        public void AnagramEqualityTestDiffChars()
        {
            Anagrams compare = new Anagrams();
            string word1 = "axaxaxaxaxa";
            string word2 = "axayayaxaxa";

            Assert.AreEqual(true, compare.wordCompare(word1, word2));
        }

        [Test]
        public void AnagramEqualityTestDiffLength()
        {
            Anagrams compare = new Anagrams();
            string word1 = "igazság";
            string word2 = "gazság";

            Assert.AreEqual(true, compare.wordCompare(word1, word2));
        }
    }
}
