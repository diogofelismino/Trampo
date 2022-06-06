using System;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int fatorial = 1;
            int num = 5;
            for (int n = 1; n <= num; n++)
            {
                fatorial *= n;
                Console.WriteLine(n + " fatorial= " + fatorial);
            }


        }
    }
}
