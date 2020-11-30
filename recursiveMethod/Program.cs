﻿/*
Эберлинг Виктор Викторович

7.a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursiveMethod
{
    class Program
    {
        static void numberPainting(double numA, double numB)
        {
            while (numA != numB)
            {
                print($"\n{numB}");
                numB--;
            }
        }
        static void pause()
        {
            Console.ReadKey();
        }
        static void print(string msg)
        {
            Console.Write(msg);
        }
        static void Main(string[] args)
        {
            #region ConsoleColor
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            #endregion
            print("Введите первое число: ");
            double numA = Convert.ToDouble(Console.ReadLine());
            print("Введите второе число: ");
            double numB = Convert.ToDouble(Console.ReadLine());
            numberPainting(numA, numB);
            pause();
        }
    }
}
