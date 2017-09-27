using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fibonacci;

namespace FibonacciTest
{
    [TestFixture]
    public class FibonacciTest
    {
        [Test]
        public void TestFibonacci0()
        {
            FibonacciCounter counter = new FibonacciCounter();
            int input = 0;

            Assert.AreEqual(1, counter.counter(input));
        }

        [Test]
        public void TestFibonacci1()
        {
            FibonacciCounter counter = new FibonacciCounter();
            int input = 1;

            Assert.AreEqual(1, counter.counter(input));
        }

        [Test]
        public void TestFibonacci2()
        {
            FibonacciCounter counter = new FibonacciCounter();
            int input = 2;

            Assert.AreEqual(2, counter.counter(input));
        }

        [Test]
        public void TestFibonacci3()
        {
            FibonacciCounter counter = new FibonacciCounter();
            int input = 3;

            Assert.AreEqual(3, counter.counter(input));
        }

        [Test]
        public void TestFibonacci4()
        {
            FibonacciCounter counter = new FibonacciCounter();
            int input = 4;

            Assert.AreEqual(5, counter.counter(input));
        }

        [Test]
        public void TestFibonacci5()
        {
            FibonacciCounter counter = new FibonacciCounter();
            int input = 5;

            Assert.AreEqual(8, counter.counter(input));
        }

        [Test]
        public void TestFibonacci6()
        {
            FibonacciCounter counter = new FibonacciCounter();
            int input = 6;

            Assert.AreEqual(13, counter.counter(input));
        }

        [Test]
        public void TestFibonacci7()
        {
            FibonacciCounter counter = new FibonacciCounter();
            int input = 7;

            Assert.AreEqual(21, counter.counter(input));
        }

        [Test]
        public void TestFibonacci8()
        {
            FibonacciCounter counter = new FibonacciCounter();
            int input = 8;

            Assert.AreEqual(34, counter.counter(input));
        }

        [Test]
        public void TestFibonacci9()
        {
            FibonacciCounter counter = new FibonacciCounter();
            int input = 9;

            Assert.AreEqual(55, counter.counter(input));
        }
    }
}
