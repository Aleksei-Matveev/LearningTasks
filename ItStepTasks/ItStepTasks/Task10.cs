using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Пользователь вводит строку и символ. В строке найти все вхождения этого символа и перевести его в верхний регистр, 
 * а также удалить часть строки , начиная  с последнего вхождения  этого символа и до конца.
 */
namespace ItStepTasks
{
    class Task10
    {
        public void DoAction()
        {
            Console.WriteLine("Введи строку");
            string str = Console.ReadLine();

            Console.WriteLine("Введи исковый символ");
            char letter = Console.ReadLine()[0];

            Console.WriteLine($"Введенная строка {str} и искомый символ {letter}");
           
            Console.WriteLine($"Строка после преобразования {str.Replace(letter, char.ToUpper(letter))}");
            
            Console.WriteLine($"Обрезанная строка {str.Substring(str.LastIndexOf('a'))}");
        }
    }
}
