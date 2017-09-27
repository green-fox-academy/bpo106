using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CowsAndBulls;
using NUnit.Framework;

namespace TestCAB
{
    [TestFixture]
    public class TestCAB
    {
        [Test]
        public void TestBaseNum()
        {
            CAB cab = new CAB();
            List<int> list = new List<int> { 6, 7, 7, 4 };
            Assert.AreEqual(list, cab.BaseNum(6774));
        }

        [Test]
        public void TestTempIn ()
        {
            CAB cab = new CAB();
            List<int> list = new List<int>{ 5, 4, 4, 2 };
            Assert.AreEqual(list, cab.TempIn("5442"));
        }

        [Test]
        public void TestNoBullNoCoW ()
        {
            CAB cab = new CAB();
            Assert.AreEqual(0, cab.Guessing(new List<int> { 1, 2, 3, 4 }, new List<int> { 5, 6, 7, 8 }));

        }

        [Test]
        public void TestBullNoCoW()
        {
            CAB cab = new CAB();
            Assert.AreEqual(4, cab.Guessing(new List<int> { 2, 2, 3, 4 }, new List<int> { 5, 5, 2, 2 }));

        }

        [Test]
        public void TestCowNoBull()
        {
            CAB cab = new CAB();
            Assert.AreEqual(10, cab.Guessing(new List<int> { 1, 0, 0, 0 }, new List<int> { 1, 2, 3, 4 }));

        }

        [Test]
        public void TestBullCoW()
        {
            CAB cab = new CAB();
            Assert.AreEqual(22, cab.Guessing(new List<int> { 1, 2, 3, 4 }, new List<int> { 1, 2, 4, 3 }));

        }

        [Test]
        public void TestWin()
        {
            CAB cab = new CAB();
            Assert.AreEqual(40, cab.Guessing(new List<int> { 1, 2, 3, 4 }, new List<int> { 1, 2, 3, 4 }));
        }
    }
}
