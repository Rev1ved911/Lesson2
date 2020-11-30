/*
Эберлинг Виктор Викторович

5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM
{
    class Program
    {
        static double ibmIndex(double growthCm, double weight)
        {
            double growthM = growthCm / 100.0;
            double ibmIndex = weight / (growthM * growthM);
            return ibmIndex;
        }
        static void ibmToNormal(double growthCm, double weight)
        {
            double weightToNormal = weight;
            if (ibmIndex(growthCm, weight) < 18.5)
            {
                while (ibmIndex(growthCm, weightToNormal) < 18.5)
                    weightToNormal++;
                print($"\n    Вам нужно набрать {weightToNormal - weight} кг.");
            }
            else
            {
                while (ibmIndex(growthCm, weightToNormal) >= 25)
                    weightToNormal--;
                print($"\n    Вам нужно сбросить {weight - weightToNormal} кг.");
            }
        }
        static void ibmIndexResult(double ibmIndex, double growthCm, double weight)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            print($"\nВаш индекс массы тела (Индекс Кетле): {ibmIndex.ToString("f2")}.");
            if (ibmIndex < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                print("\n\n    Ваш вес ниже нормы!");
                ibmToNormal(growthCm, weight);
            }
                else if (ibmIndex >= 18.5 & ibmIndex < 25)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    print("\n\n    У вас нормальный вес!");
                }
                    else if (ibmIndex >= 25 & ibmIndex < 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        print("\n\n    У вас избыточный вес!");
                        ibmToNormal(growthCm, weight);
                    }
                        else if (ibmIndex >= 30 & ibmIndex < 35)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            print("\n\n    У вас ожирение первой степени!");
                            ibmToNormal(growthCm, weight);
                        }
                            else if(ibmIndex >= 35 & ibmIndex < 40)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                print("\n\n    У вас ожирение второй степени!");
                                ibmToNormal(growthCm, weight);
                            }
                                else if (ibmIndex >= 40)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    print("\n\n    У вас ожирение третьей степени!");
                                    ibmToNormal(growthCm, weight);
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            #endregion
            print("Введите ваш рост в см.: ");
            double growthCm = Convert.ToDouble(Console.ReadLine());
            print("Введите ваш вес в кг.: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            ibmIndexResult(ibmIndex(growthCm, weight), growthCm, weight);
            pause();
        }
    }
}
