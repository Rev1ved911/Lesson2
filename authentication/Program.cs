/*
Эберлинг Виктор Викторович

4. Реализовать метод проверки логина и пароля. 
На вход подается логин и пароль. 
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
С помощью цикла do while ограничить ввод пароля тремя попытками.

З.Ы. Программы должны быть универсальны, так что я сделал возможность ввести любой логин и пароль, и по ним производить проверку. Можно и установить их сразу.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authentication
{
    class Program
    {
        static void autentification(string trueLogin, string truePwd)
        {
            int i = 0, j = 3;
            while(i < 3)
            {
                Console.Clear();
                print("Введите логин: ");
                string tryLogin = Console.ReadLine();
                print("Введите пароль ");
                string tryPwd = Console.ReadLine();
                if (trueLogin == tryLogin & truePwd == tryPwd)
                {
                    print("Авторизация пройдена!");
                    //pause();
                    break;
                }
                else
                {
                    --j;
                    print($"Введен неверный логин или пароль, повторите попытку. У вас осталось {j} попыток.");
                    i++;
                    print("\nPress any key...");
                    pause();
                    if (i == 3)
                        print("Количество попыток исчерпано.");
                }
            }
        }
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
            string login, pwd;
            /*
            Можно сразу задать логин и пароль.
            login = "root";
            pwd = "GeekBrains";
            autentification(login, pwd);
            pause();
            */
            print("Пройдите регистрацию.");
            print("\nВведите новый логин: ");
            login = Console.ReadLine();
            print("Введите новый пароль: ");
            pwd = Console.ReadLine();
            Console.Clear();
            autentification(login, pwd);
            pause();
        }
    }
}
