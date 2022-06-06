using System;

namespace proj9Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int x= 0;
            int y = 0;
            int total = 0;
            int[] soma = new int[n];

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(" ");

                x = int.Parse(vect[0]);
                y = int.Parse(vect[1]);

                if(x > y)
                {
                    for(int j = y + 1; j < x; j++)
                    {
                        if(j % 2 == 1)
                        {
                            total +=j ;
                        }
                    }
                }

                if (x < y)
                {
                    for (int j = x+ 1; j < y; j++)
                    {
                        if (j % 2 == 1)
                        {
                            total += j;
                        }
                    }
                }

                soma[i] = total;
                total = 0;


            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(soma[i]);
            }

        }
    }
}
