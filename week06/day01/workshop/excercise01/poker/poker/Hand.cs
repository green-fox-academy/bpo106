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

        public int Combination (List<int> input)
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
                return input[5] + 1;
            }
            return input[5]; 
        }

        public int Game(List<int[]> handArray1, List<int[]> handArray2)
        {
            List<int> handList1 = Convert(handArray1);
            List<int> handList2 = Convert(handArray2);

            handList1[5] = Combination(handList1);
            handList2[5] = Combination(handList2);

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
