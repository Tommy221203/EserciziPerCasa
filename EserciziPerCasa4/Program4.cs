using System;
using System.Collections.Generic;

namespace EserciziPerCasa4
{
    class Program4
    {
        static void Main(string[] args)
        {
            try
            {
                List<double> numeri4 = new List<double>();
                int c = 0;
                const int TANTI = 10;
                Random rnd = new Random();
                Console.WriteLine("inserisci un numero da 1 a 1000:");
                int f = int.Parse(Console.ReadLine());
                while (c < TANTI)
                {
                    double e = rnd.Next(0, 1000);
                    c++;
                    if (e > f)
                    {
                        numeri4.Add(e);
                    }
                    numeri4.Sort();
                }
                for (int i = 0; i < numeri4.Count; i++)
                {
                    Console.WriteLine($"{numeri4[i]}");
                }
            }
            catch { Console.WriteLine("non sono stati inseriti tutti valori numerici"); }
        }
    }
}
