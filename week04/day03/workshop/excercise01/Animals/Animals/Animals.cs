namespace Animals
{
    public class Animal
    {
        public int Hunger;
        public int Thirst;

        public Animal()
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

    }

}