/*
Эберлинг Виктор Викторович

3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summ
{
    class Program
    {
        static void cursorPosition(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
        static void printResult(int result)
        {
            cursorPosition(50, 0);
            print($"Текущий результат: {result}");
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
            Console.SetWindowSize(80, 20);
            Console.SetBufferSize(80, 20);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            #endregion
            int num = 1, summ = 0;
            print("Воводите числа:\n");
            while(num != 0)
            {
                cursorPosition(0, 1);
                print("                                                                                                                              ");
                cursorPosition(0, 1);
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 & (num % 2 == 0))
                    summ += num;
                printResult(summ);
            }
            Console.Clear();
            cursorPosition(12, 9);
            print($"Сумму всех введенных нечетных положительных чисел: {summ}");
            pause();
        }
    }
}
