using System;

namespace proj4Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];
            int soma = 0;


            for (int i = 0; i < N; i++)
            {

                string[] s = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {

                    matriz[i, j] = int.Parse(s[j]);

                    

                }

                
            }

            for (int i = 0; i < N; i++)
            {
                               
                for (int j = 0; j < N; j++)
                {

                    if ( i <j)
                    {
                       soma+= matriz[i, j];
                    }
                }
            }

            Console.WriteLine(soma);


            
        }
    }
}
