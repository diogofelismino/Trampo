using System;

namespace proj2Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];
            int[] vect = new int[N];


            for (int i = 0; i < N; i++)
            {

                string[] s = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {

                    matriz[i, j] = int.Parse(s[j]);

                    vect[i] += matriz[i, j];
                }
            }

            foreach (int i in vect)
            {
                Console.WriteLine(i);
            }


        }
    }
}
