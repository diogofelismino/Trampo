using System;

namespace projeoto7Aula4Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int maior = 0;
            int pos = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Digite um valor: ");
                valor = int.Parse(Console.ReadLine());

                if (maior < valor)
                {
                    maior = valor;
                    pos = i;
                }


            }

            Console.WriteLine($"Maior numero: {maior}");
            Console.WriteLine($"possição de entrada: {pos}");
        }
    }
}
