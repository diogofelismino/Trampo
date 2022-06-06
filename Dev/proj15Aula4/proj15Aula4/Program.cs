using System;
using System.Globalization;

namespace proj15Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            double soma =0.0;
            double media =0.0;

            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
               
            }
            

            foreach(double i in vect)
            {
                Console.Write($"{i:F1} ");
                
                soma += i;

            }

            Console.WriteLine();
            Console.WriteLine($"{soma:F2}");
            media = soma / n;
            Console.WriteLine($"{media:F2}");

        }
    }
}
