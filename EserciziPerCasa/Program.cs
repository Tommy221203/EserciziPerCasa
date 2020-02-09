using System;
using System.Collections.Generic;

namespace EserciziPerCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numeri = new List<double>();
            int c = 0;
            while(c<10)
            {
                Console.WriteLine("inserisci un numero:");
                double a = double.Parse(Console.ReadLine());
                c++;
                if(numeri.Contains(a))
                {
                    Console.WriteLine($"il valore {a} è gia contenuto nella lista.");
                }
                numeri.Add(a);
            }
        }
    }
}
