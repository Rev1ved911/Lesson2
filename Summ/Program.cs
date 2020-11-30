using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summ
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
        static void Main(string[] args)
        {
            #region ConsoleColor
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            #endregion
            int num = 1;
            while(num != 0)
            {
                print("NaN");
                pause();
            }

        }
    }
}
