using System;
/*
    Дано целое число N (>0) , найти число, полученное при прочтении
    числа N справа налево. Например, если было введено чимсло 345, 
    то программа должны вывести число 543
 */
namespace ItStepTasks
{
    class Task04
    {
        public void DoAction()
        {
            Console.WriteLine("Введи целое число больше 0");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            int result = 0;
            if (number > 0)
            {
                while (number > 0)
                {
                    result = result * 10 + number % 10;
                    number /= 10;
                }
            }
            else
                Console.WriteLine("Неверный ввод");
            Console.WriteLine($"Результат работы {result}");

        }
    }
}
