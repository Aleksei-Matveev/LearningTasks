using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Преобразовать массив так чтобы шли все отрицательные  элементы , а потом положительные (0 считать положительным)
 */
namespace ItStepTasks
{
    class Task06
    {
        public void DoAction()
        {
            int sizeArray = 20;
            int[] array = new int[sizeArray];

            initArray(array);
            showArray(array);

            Array.Sort(array);

            showArray(array);

        }

     

        private void moveRightArray(int[] array, int index)
        {
            int tmp = array[index];
            for (int i = array.Length-  1; i < index; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = tmp;
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
                array[i] = rnd.Next(-5, 5);
            }
        }
    }
}
