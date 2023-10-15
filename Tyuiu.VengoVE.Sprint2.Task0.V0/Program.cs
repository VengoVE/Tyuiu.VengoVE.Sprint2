using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ТЕОРИЯ
// Операция сравнения (==, !=, <, >, <=, >=)

// Операции ==
// Сравнивает два операнда на равенство.
// Если они равны, то операция возвращает true, если не равны, то возвращает false:
// int a = 11;
// int b = 5;
//bool c = a = b;       //  false

// Операция !=
// Сравнивает два операнда и возвращает true, если операнды не равны, и false, если они равны.
// int a = 10;
// int b = 3;
//bool c = a != b;       //  true 
//bool d = a != 10:      //  false

// Операция <
// Операция "меньше чем".Возвращает true, если первый операнд меньще второго,
// и false, если первый операнд больше второго:
// int a = 11;
// int b = 5;
// bool c == a < b;      //  false

// Операция >
// Операция "больше чем".Сравнивает два операнда и возвращает true,
// если первый операнд больше второго, иначе возвращает false:
// int a = 11;
// int b = 6;
// bool c = a > b;       //  true
// bool d = a > 25;      //  false

// Операция <=
// Операция "меньше или равно".Сравнивает два операнда и возвращает true,
// если первый операнд меньше или равно второму. Иначе возвращает false:
// int a = 12;
// int b = 3;
// bool c = a <= b;      //  false
// bool d = a <= 25;     //  true

// Операция >=
// Операция "больше или равно".Сравнивает два операнда и возвращает true,
// если первый операнд больше или равно второму. Иначе возвращает false:
// int a = 9;
// int b = 3;
// bool c = a >= b;      //  true
// bool d = a >= 25;     //  false

// Операции <, >, <=, >= имеют больший приоритет, чем == и !=.


using Tyuiu.VengoVE.Sprint2.Task0.V0.Lib;

namespace Tyuiu.VengoVE.Sprint2.Task0.V0
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1065;
            int y = 755;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i=0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
        
    }


}