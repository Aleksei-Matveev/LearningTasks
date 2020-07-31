using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  Даны целые положительные числа A и B (A<B). Вывести все целые
 *  числа от A до B включительно; каждое число должно выводиться 
 *  на новой строке; при этом каждое чисдл должно выводиться 
 *  количество раз, равное его значению(напиример, число 3 выводится
 *  3 раза)
 *  например: Если A=3, а B=7, то программа дожна сформировать в консоли 
 *  следующий вывод:
 *  3 3 3
 *  4 4 4 4
 *  5 5 5 5 5
 *  6 6 6 6 6 6
 *  7 7 7 7 7 7 7
 */


namespace ItStepTasks
{
    class Task03
    {
        public void DoAction()
        {
            Console.WriteLine("Введите начало диапазона");
            int start;
            int.TryParse(Console.ReadLine(), out start);

            Console.WriteLine("Введите конец диапазона");
            int end;
            int.TryParse(Console.ReadLine(), out end);

            if (start > end)
            {
                int tmp = start;
                start = end;
                end = tmp;
            }

            for (int i = start; i <= end; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
