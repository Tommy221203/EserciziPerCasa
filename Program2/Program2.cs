using System;
using System.Collections.Generic;

namespace EserciziPerCasa2
{
    class Program2
    {
        static void Main(string[] args)
        {
            try
            {
                int c = 0;
                List<double> numeri2 = new List<double>();
                c = 0;
                Random rnd = new Random();
                while (c < 10)
                {
                    double b = rnd.Next(1, 15);
                    c++;
                    numeri2.Add(b);
                }
                numeri2.Sort();
            }
            catch { Console.WriteLine("non sono stati inseriti tutti valori numerici"); }
        }
    }
}
