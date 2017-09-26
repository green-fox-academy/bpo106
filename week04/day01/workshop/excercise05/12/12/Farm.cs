using System.Collections.Generic;

namespace _12
{
    public class Farm
    {
        private List<Animal> Animals;
        private int FreePlace;

        public void Breed(Animal animal, int freePlace)
        {
            Animals.Add(animal);
            freePlace--;
        }

        public Animal LessHungry()
        {
            int h = Animals[0].GetHunger();
            for (int i = 1; i < Animals.Count; i++)
            {
                if (Animals[i].GetHunger() < Animals[h].GetHunger())
                {
                    h = i;
                }
            }
            return Animals[h];
        }

        public void Slaughter(Animal animal, int freePlace)
        {
            Animals.Remove(animal);
            freePlace++;
        }
    }
}