using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VengoVE.Sprint2.Task5.V2.Lib;

namespace Tyuiu.VengoVE.Sprint2.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Вэнго В. Э. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Вэнго В. Э. | ИСПб-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По данному месяцу, определите в какую пору года попадает этот месяц     *");
            Console.WriteLine("* (Зима, Лето, Весна, Осень).                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите название месяца:");
            int nameMouth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((nameMouth < 1) || (nameMouth > 12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это период года " + ds.FindMonthSeason(nameMouth);
            }

            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}
