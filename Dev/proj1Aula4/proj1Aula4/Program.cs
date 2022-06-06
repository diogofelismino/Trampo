using System;

namespace proj1Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("digite um numeroentre 2 e 1000: ");

            int valor = int.Parse(Console.ReadLine());
            int res;

            for(int i = 1; i <= 10; i++)
            {
                res = valor * i;
                Console.WriteLine($"{i} x {valor} = {res}");
            }

        }
    }
}
