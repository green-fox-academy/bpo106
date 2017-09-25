namespace _10
{
    public class Station
    {
        private int GasAmount;

        public Car Refill(Car car)
        {
            car.Swap();
            this.GasAmount -= car.NeedToFill();
            return car;
        }
    }
}