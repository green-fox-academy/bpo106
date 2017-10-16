using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker
{
    public class Hand
    {
        List<int[]> removeElement(List<int[]> list, int num)
        {
            for (int i = 0; i < list.Count - 1;)
            {
                if (list[i][2] == num)
                {
                    list.Remove(list[i]);
                }
                else
                {
                    i++;
                }
            }
            list.RemoveAt(list.Count - 1);
            return list;
        }

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
                        input[i][2] = 1;
                        input[j][2] = 1;
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
                if (handArray1[5][0] == 6)
                {
                    if (handArray1[2][0] > handArray2[2][0])
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    List<int[]> handArray1NonCombo = new List<int[]>();
                    List<int[]> handArray2NonCombo = new List<int[]>();
                    for (int i = 0; i < handArray1.Count; i++)
                    {
                        handArray1NonCombo.Add(handArray1[i]);
                        handArray2NonCombo.Add(handArray2[i]);
                    }

                    handArray1 = removeElement(handArray1, 0);
                    handArray2 = removeElement(handArray2, 0);
                    handArray1NonCombo = removeElement(handArray1NonCombo, 1);
                    handArray2NonCombo = removeElement(handArray2NonCombo, 1);

                    for (int i = 0; i < handArray1.Count; i++)
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

                    for (int i = 0; i < handArray1NonCombo.Count; i++)
                    {
                        if (handArray1NonCombo[i][0] > handArray2NonCombo[i][0])
                        {
                            return 1;
                        }
                        else if (handArray1NonCombo[i][0] < handArray2NonCombo[i][0])
                        {
                            return -1;
                        }
                    }
                    return 0;
                }
            }
        }
    }
}
