using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpies;
using NUnit.Framework;

namespace SharpieTest
{
    [TestFixture]
    public class SharpieTest
    {
        [Test]
        public void TestInkAmountPositive()
        {
            Sharpie sharpie = new Sharpie();

            for (int i = 0; i < 42; i++)
            {
                sharpie.Use();
            }

            Assert.AreEqual(true, sharpie.IsPositive());
        }

        [Test]
        public void TestInkAmountNegative()
        {
            Sharpie sharpie = new Sharpie();

            for (int i = 0; i < 100; i++)
            {
                sharpie.Use();
            }

            Assert.AreEqual(false, sharpie.IsPositive());
        }
    }
}
