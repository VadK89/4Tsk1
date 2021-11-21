using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Tsk2
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Задаем переменные
            int n;
            int pol = 0;
            int otr = 0;
            //Цикл с постусловием
            do
            {
                #region Ввод исходных данных 
                Console.WriteLine("Введите число");
                n = Convert.ToInt16(Console.ReadLine());
                #endregion
                if (n>0)
                {
                    pol++;
                }
                else if(n<0)
                {
                    otr++;
                }
            } while (n!=0);
            // Поверка выполенения условий и вывод результата
            if (pol > otr)
            {
                Console.WriteLine("количество введенных положительных чисел больше");
            }
            else if(pol<otr)
            {
                Console.WriteLine("количество введенных отрицательных чисел больше");
            }
            else
            {
                Console.WriteLine("количество положительных и отрицательных чисел совпадает");
            }
            Console.ReadKey();


        }
    }
}
