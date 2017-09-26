namespace _12
{
    public class Animal
    {
        private int Hunger;
        private int Thirst;

        Animal()
        {
            this.Hunger = 50;
            this.Thirst = 50;
        }

        public void eat()
        {
            this.Hunger--;
        }

        public void drink()
        {
            this.Thirst--;
        }

        public void play()
        {
            this.Hunger++;
            this.Thirst++;
        }

        public int GetHunger()
        {
            return Hunger;
        }
    }

}