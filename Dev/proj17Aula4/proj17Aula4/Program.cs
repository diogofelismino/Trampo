using System;

namespace proj17Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            string[] vect = new string[n];

            for(int i = 0; i < n; i++)
            {
                vect[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos: ");
            foreach (string s in vect)
            {              
                Console.WriteLine(s);
            }
        }
    }
}
