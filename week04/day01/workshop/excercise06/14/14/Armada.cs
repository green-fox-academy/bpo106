using System.Collections.Generic;

namespace _14
{
    public class Armada
    {
        private List<Ship> Fleet = new List<Ship>();

        public void FillFleet(int max)
        {
            for (int i = 0; i < max; i++)
            {
                Ship member = new Ship();
                member.FillShip(max);
                Fleet.Add(member);
            }
        }

        public bool War(Armada other)
        {
            while (this.Fleet.Count > 0 && other.Fleet.Count > 0)
            {
                if (this.Fleet[0].Battle(other.Fleet[0]))
                {
                    other.Fleet.RemoveAt(0);
                }
                else
                {
                    this.Fleet.RemoveAt(0);
                }
            }
            if (other.Fleet.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}