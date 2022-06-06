using System;

namespace proj3Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N,N];
            int[] maior = new int[N];
            int maiort = 0;

            for (int i = 0; i < N; i++)
            {

                string[] s = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {

                    matriz[i,j] = int.Parse(s[j]);

                    if (matriz[i,j] > maiort)
                    {
                        maiort = matriz[i, j];
                    }
                }

                maior[i] = maiort;

                maiort = 0;

            }


            foreach(int i in maior)
            {
                Console.WriteLine(i);
            }

        }
    }
}
