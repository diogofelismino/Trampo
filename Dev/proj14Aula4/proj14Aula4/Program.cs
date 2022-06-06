using System;

namespace proj14Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            int[] vect = new int[n];
            int[] vect2;
            int count = 0;

            for(int i = 0; i < n; i++)
            {
                vect[i] = int.Parse(Console.ReadLine());

                if(vect[i] < 0)
                {
                    count++;
                }

            }
            vect2 = new int[count];

            for (int i = 0; i < n; i++)
            {

                if (vect[i] < 0)
                {
                    vect2[i] = vect[1];
                }

            }


        }
    }
}
