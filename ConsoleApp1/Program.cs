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
        static void methodMinNumbers(double first, double second, double third)
        {
            if (first < second & first < third)
                Console.Write(first);
            else if (second < first & second < third)
                Console.Write(second);
            else
                Console.Write(third);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());
            methodMinNumbers(firstNumber, secondNumber, thirdNumber);
            Console.ReadKey();
        }
    }
}
