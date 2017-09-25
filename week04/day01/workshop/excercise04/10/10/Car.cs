namespace _10
{
    public class Car
    {
        private int GasAmount;
        private int Capacity;

        public Car()
        {
            int GasAmount = 0;
            int Capacity = 100;
        }

        public int NeedToFill()
        {
            return Capacity;
        }

        public void Swap()
        {
            GasAmount += Capacity;
            Capacity -= GasAmount;
        }
    }
}