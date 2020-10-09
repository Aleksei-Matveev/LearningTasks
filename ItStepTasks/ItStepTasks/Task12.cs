﻿using System;
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
            string[] result = s.Split(',');
            if (result.Length > 2) throw new FormatException("Не верный ввод");
            return new MyType(int.Parse(result[0]), int.Parse(result[1]));
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
            Console.WriteLine(MyType.Parse("1 12"));
            MyType myType = new MyType(4, 6);
            Console.WriteLine(myType);

        }
    }
}
