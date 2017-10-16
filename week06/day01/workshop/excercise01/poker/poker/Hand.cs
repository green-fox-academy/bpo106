using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker
{
    public class Hand
    {
        int[,] handArray1 = new int[3, 5];
        int[,] handArray2 = new int[3, 5];

        public int Game(List<int[]> handArray1, List<int[]> handArray2)
        {
            handArray1.Sort();
            handArray2.Sort();
            for (int i = 4; i >= 0; i--)
            {
                if (handArray1[i][0] > handArray2[i][0])
                {
                    return 1;
                }
                else if (handArray1[i][0] < handArray2[i][0])
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
