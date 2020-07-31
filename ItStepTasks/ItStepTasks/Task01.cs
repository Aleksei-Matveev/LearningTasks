using System;

// Даны целые положительные числа A, B, C. Значение этих чисел программа
// должна запрашивать у пользователя. На прямоугольнике размера A * B 
// размещенно максимально возможное колличество квадратов стороной C.
// Квадраты не накладываются друг на друга. Найти количество квадратов,
// размещенных на прямоугольнике, а также площадь незанятой части 
// прямоугольника.
// Необходимо предусмотреть служебные сообщения в случае, если в 
// прямоугольнике нельзя поместить ни одного квадрата со стороной C.
// (например, если значение C превыышает размер сторон прямоугольника)


namespace ItStepTasks
{
    class Task01
    {
        public void DoAction()
        {
            int sizeA,
                sizeB,
                sizeC;

            Console.WriteLine("Введите длинну стороны прямоугольника А");
            int.TryParse(Console.ReadLine(), out sizeA);

            Console.WriteLine("Введите длинну сторону прямоугольника B");
            int.TryParse(Console.ReadLine(), out sizeB);

            Console.WriteLine("Введите длинну сторону квадрата");
            int.TryParse(Console.ReadLine(), out sizeC);

            if (sizeC > sizeA || sizeC > sizeB)
                Console.WriteLine("Невозможно впихнуть невпихуемое");
            else
            {
                Console.WriteLine("Всё ок");

                int count = (sizeA / sizeC) * (sizeB / sizeC);
                Console.WriteLine($"Влезет {count} квадратов");


                int square = (sizeA - sizeC) * (sizeB - sizeC);
                Console.WriteLine($"Площадь незанятой области составила {square} ");
            }
        }
    }
}
