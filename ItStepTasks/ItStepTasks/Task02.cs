using System;

// Начальный вклад в банке равен 1000 руб. Через каждый месяц 
// размер вклада увеличивается на P процентов от имеющейся суммы
// (P -вещественное число, 0<P<25). Значение P программа должна 
// получать у пользователя. По данному P определить, через сколько
// месяцев размер вклада превысит 1100 рублей., и вывести найденное
// колличество месяцев K (целое число) и итоговый размер вклада 
// S (вещественное число)

namespace ItStepTasks
{
    class Task02
    {
        public void DoAction()
        {
            double bank = 1000;
            int countMounth = 0;
            double P;

            Console.WriteLine("Размер вклада 1000 рублей. Введите процент вклада");
            
            if(double.TryParse(Console.ReadLine(), out P) && (P > 0 && P < 25))
            {
                while(bank < 1100)
                {
                    bank += bank * (P / 100);
                    countMounth++;
                }
                Console.WriteLine($"Через {countMounth} месяцев, вклад составит {bank} рублей!!");
            }
            else
                Console.WriteLine("Неверный ввод");
        }
    }
}