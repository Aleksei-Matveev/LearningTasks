using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Написать программу, которая предлагает пользльвателю ввести число и считает сколько раз это число встречается
    в массиве
 */
namespace ItStepTasks
{
    class Task07
    {
        

        public void DoAction()
        {
            int sizeArray = 10;
            int[] array = new int[sizeArray];

            initArray(array);
            showArray(array);

            Console.WriteLine("Введите число");
            int number;
            int.TryParse(Console.ReadLine(), out number);

            Console.WriteLine($"Число {number} встречается {findNumber(array, number)} раз");
        }

        private int findNumber(int[] array, int number)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == number)
                    count++;
            }
            return count;
        }

        private void showArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        private void initArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
            }
        }
    }
}
