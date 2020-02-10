using System;
using System.Collections.Generic;

namespace EserciziPerCasa
{
    class Program1
    {
        static void Main(string[] args)
        {
            try
            {
                HashSet<double> numeri1 = new HashSet<double>() ;
                int c = 0;
                while (c < 10)
                {
                    Console.WriteLine("inserisci un numero:");
                    double a = double.Parse(Console.ReadLine());
                    c++;
                    if (numeri1.Contains(a))
                    {
                        Console.WriteLine($"il valore {a} è gia contenuto nella lista.");
                    }
                    numeri1.Add(a);
                }
            }
            catch { Console.WriteLine("non sono stati inseriti tutti valori numerici"); }
               

        }
    }
}
