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
            print("Test");
            print("\nPress any key...");
            pause();
        }
    }
}
