namespace Sharpies
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

        public bool IsPositive()
        {
            if (InkAmount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}