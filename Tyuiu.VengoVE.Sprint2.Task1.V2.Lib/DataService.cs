using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VengoVE.Sprint2.Task1.V2.Lib
{
    public class DataService : ISprint2Task1V2
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a <= d) && !(a > b) && ((b == c) || (d > b));
            res[1] = (a == b) | (b < c);
            res[2] = (c >= d) & !(c < b);
            res[3] = !(d != c) ^ (a >= d);
            res[4] = (b <= a) | !(b != c);
            res[5] = !((a > c) && (d != a));

            return res;
        }
    }
}
