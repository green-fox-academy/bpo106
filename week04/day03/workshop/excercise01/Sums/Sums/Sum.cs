using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums
{
    public class Sum
    {
        public int sumElements (List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                list[0] += list[i];
            }
            return list[0];
        }
    }
}
