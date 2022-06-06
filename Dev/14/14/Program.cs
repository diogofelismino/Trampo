using System;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] vect = new int[n];
            int[] vect2;
            int count = 0;
            int j = 0;

            for (int i = 0; i < n; i++)
            {
                vect[i] = int.Parse(Console.ReadLine());

                if (vect[i] < 0)
                {
                    count++;
                }

            }
            vect2 = new int[count];

            for (int i = 0; i < n; i++)
            {

                if (vect[i] < 0)
                {
                    vect2[j] = vect[i];
                    j++;
                }

            }

            foreach(int i in vect2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
