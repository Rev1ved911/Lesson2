/*
Эберлинг Виктор Викторович

6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
Хорошим называется число, которое делится на сумму своих цифр. 
Реализовать подсчет времени выполнения программы, используя структуру DateTime.

Чесно, нифига не понял с этой суммой чисел. Х(
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goodNumbers
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
            print($"{DateTime.Now}");
            int num = 10000, sum = 0, i = 0;
            while (num != 0)
            {
                int num1 = num;
                while (num1 != 0)
                {
                    int digit = num1 % 10;
                    sum += digit;
                    num1 /= 10;
                    print($"\n{sum}");
                }
                if((num % sum) == 0)
                    i++;
                num--;
            }
            print($"\n{i}");
            pause();
        }
    }
}
