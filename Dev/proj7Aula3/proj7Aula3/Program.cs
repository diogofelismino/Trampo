using System;
using System.Globalization;

namespace proj7Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Informe o nota do primeiro semestre: ");
            double nota1 = double.Parse(Console.ReadLine());


            Console.Write("Informe o nota do segundo semestre: ");
            double nota2 = double.Parse(Console.ReadLine());


            double media = (nota1 + nota2) / 10.0;

            if(media < 60.00) 
            {
                Console.WriteLine($"NOTA FINAL = {media:F1}");
                Console.WriteLine("REPROVADO");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL = {media:F1}");
            }

        }
    }
}
