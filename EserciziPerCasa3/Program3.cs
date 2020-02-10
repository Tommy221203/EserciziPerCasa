using System;
using System.Collections.Generic;

namespace EserciziPerCasa3
{
    class Program3
    {
        static void Main(string[] args)
        {
            try
            {
                List<double> numeri3 = new List<double>();
                Random rnd = new Random();
                int c = 0;
                while (c < 30)
                {
                    double d = rnd.Next(1, 1000);
                    c++;
                    if (d % 2 == 0)
                        numeri3.Add(d);
                }
                numeri3.Sort();
                for (int i = 0; i < numeri3.Count; i++)
                {
                    Console.WriteLine($"{numeri3[i]}");
                }
            }
            catch { Console.WriteLine("non sono stati inseriti tutti valori numerici"); }
        }
    }
}
