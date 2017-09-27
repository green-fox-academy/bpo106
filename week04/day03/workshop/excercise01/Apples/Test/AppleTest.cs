using Apples;
using NUnit.Framework;

namespace AppleTest
{
    [TestFixture]
    public class AppleTest
    {
        [Test]
        public void TestAppleCheck()
        {
            var apple = new Apple();
            Assert.AreEqual("apple", apple.GetApple());
        }

        [Test]
        public void TestPearCheck()
        {
            var apple = new Apple();
            Assert.AreEqual("pear", apple.GetApple());
        }
    }

}
