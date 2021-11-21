using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Tsk3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вводдим исходные данные
            #region Ввод исходных данных 
            Console.WriteLine("Введите длину первой стороны A прямоугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны B прямоугольника");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны C квадрата");
            int c = Convert.ToInt32(Console.ReadLine());
            #endregion
            //Задаем переменные
            int sum1 = 0;
            int sum2 = 0;
            int x = b;
            int y = c;
            int k = 0;
            //Находим площадь прямоугольника без использования умножения
            while (x != 0)
            {
                x =x-1;
                sum1 = sum1 + a;
            }
            //Находим площадь квадрата без использования умножения
            while ( y != 0)
            {
                y = y - 1;
                sum2 = sum2 + c;
            }
            //Находим количество квадратов вписанных в прямоугольнике
            int s = sum1;
            while (s > sum2)
            {
                k = k + 1;
                s = s - sum2;
            }
 
            Console.WriteLine("Количество квадратов {0}",k);
            Console.ReadKey();
        }
    }
}
