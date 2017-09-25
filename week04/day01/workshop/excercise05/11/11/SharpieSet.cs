using System.Collections.Generic;

namespace _11
{
    public class SharpieSet
    {
        private List<Sharpie> Sharpies;

        public SharpieSet()
        {
            Sharpies = new List<Sharpie>();
        }

        public bool CountUsable(Sharpie sharpie)
        {
            if (sharpie.IsPositive())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveTrash(Sharpie sharpie)
        {
            if (!(CountUsable(sharpie)))
            {
                Sharpies.Remove(sharpie);
            }
        }
    }
}