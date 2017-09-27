using NUnit.Framework;
using System.Collections.Generic;

namespace Extension
{
    [TestFixture]
    public class ExtensionTests
    {
        Extension extension = new Extension();

        [Test]
        public void TestAdd_3and3is6()
        {
            Assert.AreEqual(6, extension.Add(3, 3));
        }

        [Test]
        public void TestAdd_4and4is8()
        {
            Assert.AreEqual(8, extension.Add(4, 4));
        }

        [Test]
        public void TestMaxOfThree_First()
        {
            Assert.AreEqual(5, extension.MaxOfThree(5, 5, 3));
        }

        [Test]
        public void TestMaxOfThree_Fhird()
        {
            Assert.AreEqual(4, extension.MaxOfThree(3, 4, 2));
        }

        [Test]
        public void TestMedian_Four()
        {
            Assert.AreEqual(3, extension.Median(new List<int>() { 1, 5, 3, 3 }));
        }

        [Test]
        public void TestMedian_Five()
        {
            Assert.AreEqual(3, extension.Median(new List<int>() { 3, 1, 2, 4, 5 }));
        }

        [Test]
        public void TestIsVowel_O()
        {
            Assert.True(extension.IsVowel('O'));
        }

        [Test]
        public void TestIsVowel_oe()
        {
            Assert.True(extension.IsVowel('ö'));
        }

        [Test]
        public void testTranslate_bemutatkozik()
        {
            Assert.AreEqual("ÁvÁrvívíztűvűrővő", extension.Translate("Árvíztűrő"));
        }

        [Test]
        public void testTranslate_kolbice()
        {
            Assert.AreEqual("ŐvŐrivizeveteves", extension.Translate("Őrizetes"));
        }
    }
}