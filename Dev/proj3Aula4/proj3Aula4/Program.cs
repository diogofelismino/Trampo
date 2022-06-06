using System;
using System.Globalization;

namespace proj3Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {

           CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            
            double celsius;

            char esc = 'S';
            double fahremheit;

            do
            {

                Console.Write("Digite a temperatura em Celsius: ");
                celsius = double.Parse(Console.ReadLine());

                fahremheit = (celsius * 1.8) + 32;
                Console.WriteLine($"Equivalente em Fahrenheit: {fahremheit:F1}");

                Console.Write("Deseja repetir (S/N) ?");
                esc = char.Parse(Console.ReadLine().ToUpper());


            } while (esc != 'N');


            

            

        }
    }
}
