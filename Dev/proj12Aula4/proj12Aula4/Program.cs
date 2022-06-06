using System;

namespace proj12Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int X = int.Parse(Console.ReadLine());
            int Z = 0;
            int valor = 0;
            int cont = 0;

            while (Z < X || Z==X)
            {
                Z = int.Parse(Console.ReadLine());

                if (Z > X)
                  
                {
                    valor = X;
                    while (valor < Z)
                    {
                        valor += (X+1);
                        cont++;
                    }
                }


            }

            Console.WriteLine(cont);

            

        }
    }
}
