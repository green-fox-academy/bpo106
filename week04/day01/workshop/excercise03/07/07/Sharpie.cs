namespace _07
{
    public class Sharpie
    {
        public string Color;
        public float Width;
        private float InkAmount = 100;

        public void Use()
        {
            InkAmount--;
        }
    }
}