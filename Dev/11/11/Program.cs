using System;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = Console.ReadLine().Split(" ");
            int A = int.Parse(vect[0]);
            int N = 0;
            int soma = 0;
            int cont = 0;

            for (int i = 1; i < vect.Length; i++)
            {

                cont = int.Parse(vect[i]);

               if(cont > 0)
                {
                    N = Math.Abs(int.Parse(vect[i]));
                }
                
            }



            for (int i = 0; i < N; i++)
            {

                soma += (A + i);

            }


            Console.WriteLine(soma);
        }
    }
}
