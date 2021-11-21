using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Tsk1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод тсходных данных
            #region Ввод исходных данных 
            Console.WriteLine("Введите число N>0");
            int n = Convert.ToInt16(Console.ReadLine());
            #endregion
            // Задаем переменнные
            int i = 0;
            int x=1;
            // Цикл с параметром for и выводом результатов
            for (; i <= n; i++)
            {
                x += 2 * i - 1;
                Console.WriteLine("Квадрат от числа {0} равен {1} ", i, x);
            }
             Console.ReadKey();
        }
    }
}
