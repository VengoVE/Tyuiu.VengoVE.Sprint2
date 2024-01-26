using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VengoVE.Sprint2.Task2.V20.Lib
{
    public class DataService : ISprint2Task2V20
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && ( x <= 11) && (y >= 3) && (y <= 13))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
