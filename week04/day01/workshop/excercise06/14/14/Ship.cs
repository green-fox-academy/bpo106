using System;
using System.Collections.Generic;

namespace _14
{
    public class Ship
    {
        Random random = new Random();
        private List<Pirate> Crew = new List<Pirate>();
        private int alive = 0;

        public void FillShip(int max)
        {
            for (int i = 0; i < max; i++)
            {
                Crew.Add(new Pirate());
                alive++;
            }
        }

        public void ShipStatus()
        {
            Crew[0].CaptainStatus(Crew[0]);
            Console.WriteLine("Number of alive pirates: {0}\n", alive);
        }

        public bool Battle(Ship other)
        {
            if (this.alive * (this.Crew[0].RumStatus()) > other.alive * (other.Crew[0].RumStatus()))
            {                
                for (int i = 0; i < random.Next(other.Crew.Count); i++)
                {
                    Console.WriteLine(other.Crew[random.Next(other.Crew.Count)].Die());
                    other.alive--;
                }

                for (int i = 0; i < random.Next(42); i++)
                {
                    this.Crew[0].DrinkSomeRum();
                }

                return true;
            }
            else
            {
                for (int i = 0; i < random.Next(other.Crew.Count); i++)
                {
                    Console.WriteLine(this.Crew[random.Next(this.Crew.Count)].Die());
                    this.alive--;
                }

                for (int i = 0; i < random.Next(42); i++)
                {
                    other.Crew[0].DrinkSomeRum();
                }

                return false;
            }
        }
    }
}