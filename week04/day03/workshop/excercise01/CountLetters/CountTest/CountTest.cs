using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CountLetters;

namespace CountTest
{
    [TestFixture]
    public class CountTest
    {
        [Test]
        public void dicTest ()
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            LetterCounter letcount = new LetterCounter();
            string test = "Negyvenkettő";
            dic.Add('N', 1);
            dic.Add('e', 3);
            dic.Add('g', 1);
            dic.Add('y', 1);
            dic.Add('v', 1);
            dic.Add('n', 1);
            dic.Add('k', 1);
            dic.Add('t', 2);
            dic.Add('ő', 1);

            Assert.AreEqual(dic, letcount.charLister(test));
        }

        [Test]
        public void dicTestDiffNum()
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            LetterCounter letcount = new LetterCounter();
            string test = "Negyvenkettő";
            dic.Add('N', 1);
            dic.Add('e', 3);
            dic.Add('g', 1);
            dic.Add('y', 1);
            dic.Add('v', 1);
            dic.Add('n', 42);
            dic.Add('k', 1);
            dic.Add('t', 2);
            dic.Add('ő', 1);

            Assert.AreEqual(dic, letcount.charLister(test));
        }

        [Test]
        public void dicTestDiffChars()
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            LetterCounter letcount = new LetterCounter();
            string test = "Negyvenkettő";
            dic.Add('N', 1);
            dic.Add('e', 3);
            dic.Add('g', 1);
            dic.Add('y', 1);
            dic.Add('v', 1);
            dic.Add('k', 1);
            dic.Add('t', 2);
            dic.Add('ő', 1);

            Assert.AreEqual(dic, letcount.charLister(test));
        }
    }
}
