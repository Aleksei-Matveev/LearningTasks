using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    В двумерном массиве порядка M на N поменяйте местами заданные столбцы
 */
namespace ItStepTasks
{
    class Task08
    {
        public void DoAction()
        {
            int sizeM = 5, sizeN = 5;
            int[,] array = new int[sizeM, sizeN];

            initArray(array);
            showArray(array);
            changeArray(ref array);
            Console.WriteLine();
            showArray(array);
        }

        private void changeArray(ref int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            int[,] tmp = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    tmp[i, j] = array[j, i];
                }
            }

            array = tmp;
        }

        private void showArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        private void initArray(int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                }
            }
        }
    }
}