using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sums;

namespace SumTest
{
    [TestFixture]
    public class SumTest
    {
        [Test]
        public void TestSumEqualMultiple()
        {
            var list = new List<int>();

            list.Add(6);
            list.Add(9);
            list.Add(42);
            list.Add(54);

            var sum = new Sum();

            Assert.AreEqual(111,sum.sumElements(list));
        }

        [Test]
        public void TestSumEqualUnique()
        {
            var list = new List<int>();

            list.Add(42);

            var sum = new Sum();

            Assert.AreEqual(42, sum.sumElements(list));
        }

        [Test]
        public void TestSumEqualEmpty()
        {
            var list = new List<int>();

            var sum = new Sum();

            Assert.AreEqual(0, sum.sumElements(list));
        }

        [Test]
        public void TestSumEqualNull()
        {
            var list = new List<int>();

            list.Add(Int32.Parse(null));

            var sum = new Sum();

            Assert.AreEqual(null, sum.sumElements(list));
        }
    }
}
