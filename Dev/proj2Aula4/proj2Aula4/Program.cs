using System;

namespace proj2Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(-5 % 2);


            Console.Write("entre com um valor: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("entre com um valor: ");
            int y = int.Parse(Console.ReadLine());

            int soma = 0;

            if(x < y)
            {
                for (int i = Math.Abs(x); Math.Abs(i) <= y; i++)
                {
                    if (Math.Abs(i) % 2 == 1 )
                    {
                        soma += Math.Abs(i);
                    }
                }

            }
            else
            {
                for (int i = Math.Abs(y); Math.Abs(i) <= x; i++)
                {
                    if (Math.Abs(i) % 2 == 1 )
                    {
                        soma += Math.Abs(i);
                    }
                }

            }




            Console.WriteLine(soma);
        }
    }
}
