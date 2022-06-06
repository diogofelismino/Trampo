using System;

namespace testeaula7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[M, N];
            int[] vect = new int[N - 1];

            int u = (M - 1);
            int t = (N - 1);
            int y = 1;
            int pri = 0;

            int gira;

            for (int i = 0; i < M; i++)
            {

                string[] s = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {

                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            gira = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {



                for (int j = 0; j < (N - 1); j++)
                {
                    if (i == (gira - 1))
                    {

                        pri = matriz[i, t];
                        vect[j] = matriz[i, u - 1];
                        u--;

                        

                    }

                }

            }


            for (int i = 0; i < M; i++)
            {



                for (int j = 0; j < (N-1) ; j++)
                {
                    if (i == (gira - 1))
                    {

                       

                        matriz[i, 0] = pri;
                        matriz[i, y] = vect[j];
                        y++;


                    }

                }

            }





            for (int i = 0; i < M; i++)
            {



                for (int j = 0; j < N; j++)
                {


                    Console.Write(matriz[i, j] + " ");


                }

                Console.WriteLine();
            }
        }
    }
}
