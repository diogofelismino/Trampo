using System;

namespace proj10Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect =Console.ReadLine().Split(" ");

            int valorIn = int.Parse(vect[0]);
            int valorFn = int.Parse(vect[1]);
            int valor= 0;

            for (int i = 1; i <= valorFn; i++)
            {
                Console.Write(i + " ");
                valor++;
                if (valor == 3)
                {
                    Console.WriteLine();
                    valor = 0;
                }
                
            }


        }
    }
}
