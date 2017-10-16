using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker
{
    public class Hand
    {
        public List<int> Convert (List<int[]> input)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                list.Add(input[i][0]);
            }
            list.Sort();
            list.Add(0);
            return list;
        }

        public int Combination (List<int[]> colors, List<int> input)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (input[i] == input[j])
                    {
                        input[5]++;
                    }
                }
            }

            if (input[5] == 6)
            {
                input[5]++;
            }
            if (input[5] == 4)
            {
                input[5] = 6;
            }
            if (input[5] == 0 && input[0] + 4 == input[4])
            {
                input[5] = 4;
            }
            if (input[5] % 4 == 0 && colors[0][1] == colors[1][1] && colors[0][1] == colors[2][1] && colors[0][1] == colors[3][1] && colors[0][1] == colors[4][1])
            {
                if (input[0] + 4 == input[4])
                {
                    input[5] = 8;
                }
                else
                {
                    input[5] = 5;
                }
            }

            return input[5];
            
        }

        public int Game(List<int[]> handArray1, List<int[]> handArray2)
        {
            List<int> handList1 = Convert(handArray1);
            List<int> handList2 = Convert(handArray2);

            handList1[5] = Combination(handArray1, handList1);
            handList2[5] = Combination(handArray2, handList2);

            if (handList1[5] > handList2[5])
            {
                return 1;
            }
            else if (handList1[5] < handList2[5])
            {
                return -1;
            }
            else
            {
                for (int i = 4; i >= 0; i--)
                {
                    if (handList1[i] > handList2[i])
                    {
                        return 1;
                    }
                    else if (handList1[i] < handList2[i])
                    {
                        return -1;
                    }
                }
                return 0;
            }
        }
    }
}
