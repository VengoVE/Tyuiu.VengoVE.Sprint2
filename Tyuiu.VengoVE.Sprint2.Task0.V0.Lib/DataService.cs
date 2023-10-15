using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ЗАДАНИЕ
// Написать программу из операций сравнений (== , !=, <, >, <=, >=, последовательность операций не должна нарушаться)
// и арифметических выражений, которая вернет логическую последовательность(массив):
// (True, False, False, False, False, False), при x = 1065, y = 755

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VengoVE.Sprint2.Task0.V0.Lib
{
    public class DataService : ISprint2Task0V17
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 310 == y;
            res[1] = x != y;
            res[2] = x < y;
            res[3] = x - 1000 > y;
            res[4] = x <= y;
            res[5] = x - 1000 >= y;

            return res;
        }
    }
}
