using System;
using System.Globalization;

namespace proj6Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            int N = int.Parse(Console.ReadLine());

            double[,] matriz = new double[N, N];

            double soma = 0;

            

            for (int i = 0; i < N; i++)
            {

                string[] s = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = double.Parse(s[j]);

                    if (matriz[i, j] > 0)
                    {
                        soma += matriz[i, j];
                    }
                }
            }



            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA DOS POSITIVOS: {soma}");

            Console.Write("Linha escolhida: ");
            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    
                    if(i == linha)
                    {
                        Console.Write(matriz[i,j] + " ");
                    }
                    
                }
            }
            Console.WriteLine();

            Console.Write("Coluna escolhida: ");
            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {

                    if (j == coluna)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }

                }
            }
            Console.WriteLine();

            Console.Write("Diagonal principal: ");
            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {

                    if (i == j)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }

                }
            }
            Console.WriteLine();

            Console.Write("Matriz alterada: ");
            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {

                    if (matriz[i,j] < 0)
                    {
                        matriz[i,j] = Math.Pow(matriz[i,j], 2);
                    }

                    Console.Write(matriz[i, j] + " ");

                }
                Console.WriteLine();
            }
            


        }
    }
}
