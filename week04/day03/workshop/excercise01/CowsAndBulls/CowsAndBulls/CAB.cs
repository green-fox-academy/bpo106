using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    public class CAB
    {
        static Random random = new Random();
        string state = "playing";
        int guesses = 0;
        int randomNum = random.Next(1000, 10000);

        public List<int> BaseNum(int randomNum)
        {
            List<int> guess = new List<int>();

            guess.Add((randomNum) / 1000);
            guess.Add((randomNum % 1000) / 100);
            guess.Add(((randomNum % 1000) % 100) / 10);
            guess.Add(((randomNum % 1000) % 100) % 10);

            return guess;
        }

        public List<int> TempIn(string tempstr)
        {
            List<int> temp = new List<int>();

            temp.Add(Int32.Parse(tempstr) / 1000);
            temp.Add((Int32.Parse(tempstr) % 1000) / 100);
            temp.Add(((Int32.Parse(tempstr) % 1000) % 100) / 10);
            temp.Add(((Int32.Parse(tempstr) % 1000) % 100) % 10);

            guesses++;

            return temp;
        }

        public int Guessing(List<int> guess, List<int> temp)
        {
            int cow = 0;
            int bull = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (guess[i] == temp[j]) 
                    {
                        if (i == j)
                        {
                            cow++;
                        }
                        else
                        {
                            bull++;
                        }
                    }
                }
            }
            for (int i = 0; i < cow; i++)
            {
                Console.WriteLine("Cow");
            }

            for (int i = 0; i < bull; i++)
            {
                Console.WriteLine("Bull");
            }

            if (cow == 4 && bull == 0)
            {
                state = "finished";
                Console.WriteLine("You won! (Guesses: {0})", guesses);
            }
            return 10 * cow + bull;
        }
    }
}
