using System;

namespace proj1Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nota = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Escreva o nota do aluno {i + 1}: ");
                nota[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {

                if (nota[i] >= 6)
                {
                    Console.WriteLine($"Aluno {i +1} aprovado!!!");
                }
                else
                {
                    Console.WriteLine($"Aluno {i +1} reprovado!!!");
                }

            }

        }
    }
}
