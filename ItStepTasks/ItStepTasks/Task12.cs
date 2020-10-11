using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
/*
 *  Разработать собственный собственный структурный тип
 *  данных для хранения целочисленных коофициентов А и В
 *  линейного уравнения A+X + B+Y =0
 *  В классе реализовать статический петод Parse , которые
 *  принимает строку со значениями коэффициентов, разделенных запятой
 *  или пробелом. В случае передачи в метод строки недопустимого
 *  формата генерируется исключение FormatException
 */
namespace ItStepTasks
{
    class MyType
    {
        private int a;
        private int b;
        private int x;
        private int y;

        public MyType(int A, int B)
        {
            this.a = A;
            this.b = B;
        }
        public static MyType Parse(string s)
        {
            string[] result;
            if (s.Split(',').Length != 2 )
            {
                if (s.Split(' ').Length != 2)
                    throw new FormatException("Лишний пробел");
                else
                    result = s.Split(' ');
                throw new FormatException("Лишняя запятая");

            }
            else
            {
                result = s.Split(',');
            }

            try
            {
                return new MyType(int.Parse(result[0]), int.Parse(result[1]));
            }
            catch (Exception)
            {

                throw new FormatException("Используйте только целые цисла");
            }
            
        }
        public override string ToString()
        {
            return $"{a}x + {b}x = 0";
        }
    }

    class Task12
    {
        public void DoAction()
        {
            Console.WriteLine("Введи два коэфициента через запятую или пробел");
            Console.WriteLine($"Результат :{MyType.Parse(Console.ReadLine())}");
        }
    }
}
