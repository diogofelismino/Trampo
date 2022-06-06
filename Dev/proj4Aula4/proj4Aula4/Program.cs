using System;

namespace proj4Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com um valor de 1 até 1000: ");
            int valor = int.Parse(Console.ReadLine());

            for(int i = 1; i <= valor; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine($"Valores impares entre 1 e {valor}: {i}");
                }
            }

        }
    }
}
