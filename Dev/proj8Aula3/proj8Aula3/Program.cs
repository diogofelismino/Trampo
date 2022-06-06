using System;

namespace proj8Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vect = new int[3];
            int menor = 10;
            


            for (int i = 0; i < 3; i++)
            {
                Console.Write("entre com os valores: ");
                vect[i] = int.Parse(Console.ReadLine());

                

                if(menor > vect[i])
                {
                    menor = vect[i];
                }

            }

            Console.WriteLine($"MENOR = {menor}");

        }
    }
}
