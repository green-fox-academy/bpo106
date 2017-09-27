using Animals;
using NUnit.Framework;

namespace TestAnimals
{
    [TestFixture]
    public class TestAnimals
    {
        [Test]
        public void TestAnimalStatusEat ()
        {
            Animal animal = new Animal();
            int test = animal.Hunger;
            animal.eat();
            Assert.AreEqual(test - 1, animal.Hunger);
        }

        [Test]
        public void TestAnimalStatusDrink()
        {
            Animal animal = new Animal();
            int test = animal.Thirst;
            animal.drink();
            Assert.AreEqual(test - 1, animal.Thirst);
        }

        [Test]
        public void TestAnimalStatusPlay()
        {
            Animal animal = new Animal();
            int test1 = animal.Thirst;
            int test2 = animal.Hunger;
            animal.play();
            Assert.AreEqual(test1 + 1, animal.Thirst);
            Assert.AreEqual(test2 + 1, animal.Hunger);
        }
    }
}
