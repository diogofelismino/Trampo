using System;

namespace proj23Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool verifica = true;

            int valor1;
            int valor2;

            while (verifica)
            {
                Console.Write("Informe o valor 1: ");
                valor1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o valor 2: ");
                valor2 = int.Parse(Console.ReadLine());

                if (valor1 > valor2)
                {
                    Console.WriteLine("Decresente");
                }
                else if(valor1 < valor2)
                {
                    Console.WriteLine("Crescente");
                }

                if(valor1 == valor2)
                {
                    verifica = false;
                }


            }

        }
    }
}
