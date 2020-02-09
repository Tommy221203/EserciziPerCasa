using System;
using System.Collections.Generic;

namespace EserciziPerCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("primo esercizio");
            List<double> numeri1 = new List<double>();
            int c = 0;
            while(c<1)
            {
                Console.WriteLine("inserisci un numero:");
                double a = double.Parse(Console.ReadLine());
                c++;
                if(numeri1.Contains(a))
                {
                    Console.WriteLine($"il valore {a} è gia contenuto nella lista");
                }
                numeri1.Add(a);
            }
            Console.WriteLine("secondo esercizio");
            List<double> numeri2 = new List<double>();
            c = 0;
            Random rnd = new Random();
            while (c<1)
            {
                double b = rnd.Next(1, 15);
                c++;
                numeri2.Add(b);
                numeri2.Sort();
            }
            Console.WriteLine("terzo esercizio");
            List<double> numeri3 = new List<double>();
            c = 0;
            while(c<30)
            {
                double d = rnd.Next(1, 1000);
                c++;
                if (d % 2 == 0)
                    numeri3.Add(d);numeri3.Sort();
            }
            for(int i=0;i<numeri3.Count;i++)
            {
                Console.WriteLine($"{numeri3[i]}");
            }


        }
    }
}
