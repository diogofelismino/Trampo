using System;

namespace proj8Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o tamanho da matriz: ");
            int N= int.Parse(Console.ReadLine());

            double[,] matriz = new double[N,N];

            Console.Write("Escolha uma linha da matriz: ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("deseja somar ou ver a media [S/M]: ");
            char esc = char.Parse(Console.ReadLine());

            double soma = 0;
            double media = 0;


            for (int i = 0; i < N; i++)
            {

               

                for (int j = 0; j < N; j++)
                {
                     matriz[i,j] =(double) j;
                }
            }




            if(esc == 'S')
            {

                for (int i = 0; i < N; i++)
                {

                    for (int j = 0; j < N; j++)
                    {
                        if(i == linha)
                        {
                            soma += matriz[i, j];
                        }
                    }
                }
                Console.WriteLine($"Soma: {soma}");

            }
            else if(esc == 'M')
            {
                for (int i = 0; i < N; i++)
                {

                    for (int j = 0; j < N; j++)
                    {
                        if (i == linha)
                        {
                            soma += matriz[i, j];
                            media = soma / N;
                        }
                    }
                }

                Console.WriteLine($"Media: {media}");

            }


        }
    }
}
