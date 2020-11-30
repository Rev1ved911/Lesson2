/*
Эберлинг Виктор Викторович

2. Написать метод подсчета количества цифр числа.

З.Ы. Немного не понял задания. 
     Надеюсь сделал то, что просили. 
     Если это число будет начинаться не с нуля, 
     то можно начинать делить на 10, 
     но есть число будет типа 0001010101, 
     то деление уже не прокатит,
     так что вывел просто длинну строки, 
     не вижу никакой обходимости делать метод отдельный,
     либо я не понял задания.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitsNumbers
{
    class Program
    {
        static void print(string msg)
        {
            Console.Write(msg);
        }
        static void pause()
        {
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            #region ConsoleColor
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            #endregion
            print("Пишите: ");
            string text = Console.ReadLine();
            int length = text.Length;
            print($"\n    В написанной вами строке {length} символов.");
            print("\n\n    Press any key...");
            pause();
        }
    }
}