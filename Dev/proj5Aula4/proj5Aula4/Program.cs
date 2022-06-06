using System;

namespace proj5Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos valores serão lidos: ");
            int n = int.Parse(Console.ReadLine());

            int valor;

            int dentro =0 ;
            int fora=0;

            for (int i = 0; i < n; i++)
            {

                valor = int.Parse(Console.ReadLine());

                if(valor >= 10 && valor <= 20)
                {
                    dentro++; 
                }
                else
                {
                    fora++;
                }


            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");

        }
    }
}
