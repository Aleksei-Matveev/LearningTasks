using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Сжать массив удалив из него все 0 и заполнить освободившиеся справа элементы  значениями -1
 */
namespace ItStepTasks
{
    class Task05
    {
        public void DoAction()
        {
            int sizeArray = 50;
            int[] array = new int[sizeArray];

            initArray(array);
            showArray(array);
            compressArray(array);
            showArray(array);

        }

        private void compressArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    moveleftArray(array, i);
                    i--;
                }
            }
        }

        private void moveleftArray(int[] array, int index)
        {
            for (int i = index; i < array.Length-1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = -1;
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