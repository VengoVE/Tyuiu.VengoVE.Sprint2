using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VengoVE.Sprint2.Task3.V19.Lib
{
    public class DataService : ISprint2Task3V19
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = Math.Pow(x, 2) + Math.Pow((x + 1) / (x - 1), x);
            }
            else
            {
                if (x == 0)
                {
                    y = (Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) + 13) / (Math.Pow(x, 2) + Math.Sin(Math.Pow(x, 2)) + 9);
                }
                else
                {
                    if ((x >= -23) && (x < 0))
                    {
                        y = Math.Pow(1 + (1 / Math.Pow(x, 2)), 2);
                    }
                    else
                    {
                        if (x <= -23)
                        {
                            y = x + 10 * x - (1 / x);
                        }
                    }
                }
            }

            return Math.Round(y, 3);
        }
    }
}
