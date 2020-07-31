using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Создать метод принимающий , введенную пользователем , строку и выводящей на экран
статистику по этой строке. Статистика должна содержать:
1. Общее колличество символов
2. Количество букв в верхнем регистре и в нижнем
3. Количество цифр
4. Количество символов пунктуации
5. Количество пробельных символов
 */

namespace ItStepTasks
{
    class Task09
    {
        public void DoAction()
        {
            Console.WriteLine("Введите строку");
            string inputStr = Console.ReadLine();

            Statistic(inputStr);
        }

        void Statistic(string str)
        {
            Console.WriteLine($"Длинна строки {str.Length} символа(ов)");
            Console.WriteLine($"В верхнем регистре {UpperCaseCount(str)} символа(ов)");
            Console.WriteLine($"В нижнем регистре {LowerCaseCount(str)} символа(ов)");
            Console.WriteLine($"Количество цифр {DigitCount(str)} символа(ов)");
            Console.WriteLine($"Количество знаков пунктуации {PunctuationCount(str)} символа(ов)");
            Console.WriteLine($"Количество пробелов {WhiteSpaceCount(str)} символа(ов)");

        }
        int UpperCaseCount(string str)
        {
            int count = 0;
            char[] tmp = str.ToCharArray();
            for (int i = 0; i < tmp.Length; i++)
            {
                if (char.IsUpper(tmp[i]))
                    count++;
            }
            return count;
        }
        int LowerCaseCount(string str)
        {
            int count = 0;
            char[] tmp = str.ToCharArray();
            for (int i = 0; i < tmp.Length; i++)
            {
                if (char.IsLower(tmp[i]))
                    count++;
            }
            return count;
        }
        int DigitCount(string str)
        {
            int count = 0;
            char[] tmp = str.ToCharArray();
            for (int i = 0; i < tmp.Length; i++)
            {
                if (char.IsDigit(tmp[i]))
                    count++;
            }
            return count;
        }
        int PunctuationCount(string str)
        {
            int count = 0;
            char[] tmp = str.ToCharArray();
            for (int i = 0; i < tmp.Length; i++)
            {
                if (char.IsPunctuation(tmp[i]))
                    count++;
            }
            return count;
        }
        int WhiteSpaceCount(string str)
        {
            int count = 0;
            char[] tmp = str.ToCharArray();
            for (int i = 0; i < tmp.Length; i++)
            {
                if (char.IsWhiteSpace(tmp[i]))
                    count++;
            }
            return count;
        }
    }
}