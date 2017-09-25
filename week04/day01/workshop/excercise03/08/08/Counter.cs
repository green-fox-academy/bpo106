namespace _08
{
    public class Counter
    {
        private int integer = 0;

        public void Add(int num)
        {
            integer += num;
        }

        public void Add()
        {
            integer++;
        }

        public string Get()
        {
            return integer.ToString(); 
        }

        public void Reset()
        {
            integer = 0;
        }
    }
}