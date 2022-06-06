using System;
using System.Globalization;

namespace proj12Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            string[] vect1 = Console.ReadLine().Split(" ");
            string[] vect2 = Console.ReadLine().Split(" ");

            int idade01 = int.Parse(vect1[1]);
            int idade02 = int.Parse(vect2[1]);
            double media = (idade01 + idade02)/ 2.0;

            Console.WriteLine($"A idade média de {vect1[0]} e {vect2[0]} é de {media.ToString("F1")}");

        }
    }
}
