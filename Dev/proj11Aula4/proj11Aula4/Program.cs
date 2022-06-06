using System;

namespace proj11Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] vect = Console.ReadLine().Split(" ");
            int A = int.Parse(vect[0]);
            int N = 0;
            int soma = 0;

            for (int i = 1; i <= vect.Length; i++)
            {
                if (int.Parse(vect[i + 1]) > 0)
                {
                    N =int.Parse(vect[i ]);
                }
                else
                {
                    N =Math.Abs(int.Parse(vect[i]));
                }
            }

            

            for(int i = 0 ; i <= N; i++)
            {

                soma += (A + i);

            }


            Console.WriteLine(soma);
        }
    }
}
