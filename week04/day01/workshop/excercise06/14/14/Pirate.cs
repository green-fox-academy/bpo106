using System;

namespace _14
{
    public class Pirate
    {
        private int Rum = 0;
        private bool IsPassedOut = false;
        private bool HasParrot = false;
        private bool IsDead = false;
        private Random random = new Random();

        public int DrinkSomeRum()
        {
            return Rum++;
        }

        public int RumStatus()
        {
            return Rum;
        }

        public string HowsItGoingMate()
        {
            if (Rum <= 4)
            {
                return "Pour me anudder!";
            }
            else
            {
                IsPassedOut = true;
                return "Arghh, I'ma Pirate. How d'ya d'ink its goin?";
            }
        }

        public string Die()
        {
            IsDead = true;
            return "He's dead.";
        }

        public void Brawl(Pirate other)
        {
            if ((other.IsPassedOut || other.IsDead || this.IsPassedOut || this.IsDead) == false)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        other.Die();
                        break;
                    case 1:
                        this.Die();
                        break;
                    default:
                        other.Die();
                        this.Die();
                        break;
                }
            }
        }

        public void AddParrot()
        {
            HasParrot = true;
        }

        public void CaptainStatus(Pirate captain)
        {
            Console.WriteLine("Number of consumed bottles of rum: {0}", captain.Rum);
            if (captain.IsDead)
            {
                Console.WriteLine(captain.Die());
            }
            else
            {
                Console.WriteLine(captain.HowsItGoingMate());
            }
        }

        public Pirate()
        {

        }
    }
}