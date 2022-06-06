using System;
using System.Globalization;

namespace proj9Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Informe o tempo de consumo: ");
            int tempo = int.Parse(Console.ReadLine());

            double valor = 50.00;

            if(tempo <= 100)
            {
                Console.WriteLine("Valor a pagar: R$ 50.00");
            }
            else
            {
                for(int i = 100; i < tempo; i++)
                {
                    valor += 2.00;
                }

                Console.WriteLine($"Valor a pagar: R$ {valor:F2}");
            }


        }
    }
}
