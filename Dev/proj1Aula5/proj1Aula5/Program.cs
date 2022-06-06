using System;

namespace proj1Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] vect = Console.ReadLine().Split(" ");

            int M = int.Parse(vect[0]);
            int N = int.Parse(vect[1]);

            int[,] neg = new int[M,N];

            for(int i = 0; i < M; i++)
            {

                string[] s = Console.ReadLine().Split(" "); 

                for(int j = 0; j < N; j++)
                {
                    if(int.Parse(s[j]) < 0)
                    {
                        neg[i, j] = int.Parse(s[j]);
                    }

                   
                }
            }

            Console.WriteLine("Valores negativos: ");


            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(neg[i, j] < 0) 
                    {
                        Console.WriteLine(neg[i, j]);
                    }
                    
                }
            }



        }
    }
}
