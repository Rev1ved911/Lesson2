/*
Эберлинг Виктор Викторович

1. Написать метод, возвращающий минимальное из трех чисел.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minNumber
{
    class Program
    {

        static void pause()
        {
            Console.ReadKey();
        }
        static void print(string msg)
        {
            Console.Write(msg);
        }
        static void printNum(double num)
        {
            Console.WriteLine($"\nНаименьшее число: {num}");
        }
        static void methodMinNumbers(double first, double second, double third)
        {
            if (first < second & first < third)
                printNum(first);
            else if (second < first & second < third)
                printNum(second);
            else
                printNum(third);
        }
        static void Main(string[] args)
        {
            #region ConsoleColor
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            #endregion
            print("Введите первое число: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            print("Введите второе число: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            print("Введите третье число: ");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());
            methodMinNumbers(firstNumber, secondNumber, thirdNumber);
            print("\nPress any key...");
            pause();
        }
    }
}
