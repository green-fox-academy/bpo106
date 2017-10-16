using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker
{
    public class Hand
    {
        List<int[]> sortElements(List<int[]> list)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (list[i][0] < list[j][0])
                    {
                        int tmp = list[i][0];
                        list[i][0] = list[j][0];
                        list[j][0] = tmp;
                        tmp = list[i][1];
                        list[i][1] = list[j][1];
                        list[j][1] = tmp;
                    }
                }
            }
            return list;
        }

        public List<int[]> Combination (List<int[]> input)
        {
            input = sortElements(input);
            input.Add(new int[]{ 0 });
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (input[i][0] == input[j][0])
                    {
                        input[5][0]++;
                    }
                }
            }

            if (input[5][0] == 6)
            {
                input[5][0]++;
            }
            if (input[5][0] == 4)
            {
                input[5][0] = 6;
            }
            if (input[5][0] == 0 && input[4][0] + 4 == input[0][0])
            {
                input[5][0] = 4;
            }
            if (input[5][0] % 4 == 0 && input[0][1] == input[1][1] && input[0][1] == input[2][1] && input[0][1] == input[3][1] && input[0][1] == input[4][1])
            {
                if (input[4][0] + 4 == input[0][0])
                {
                    input[5][0] = 8;
                }
                else
                {
                    input[5][0] = 5;
                }
            }

            return input;
            
        }

        public int Game(List<int[]> handArray1, List<int[]> handArray2)
        {
            handArray1 = Combination(handArray1);
            handArray2 = Combination(handArray2);

            if (handArray1[5][0] > handArray2[5][0])
            {
                return 1;
            }
            else if (handArray1[5][0] < handArray2[5][0])
            {
                return -1;
            }
            else
            {
                for (int i = 0; i <5; i++)
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
}
