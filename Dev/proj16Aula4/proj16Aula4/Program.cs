using System;
using System.Globalization;

namespace proj16Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture =  CultureInfo.InvariantCulture;
            
            int n = int.Parse(Console.ReadLine());

            string[] vect; 
            string nome;
            int idade;
            double altura;
            double media;
            double total = 0;
            double pos = 0;

            for(int i = 0; i < n; i++)
            {
                vect = Console.ReadLine().Split(" ");

                nome = vect[0];
                idade = int.Parse(vect[1]);
                altura = double.Parse(vect[2]);

                
                total += altura;

                if(idade < 16)
                {
                    pos++;
                }
                
               

            }

            media = total / n;

            Console.WriteLine($"Altura média: {media:F2}");
            Console.WriteLine($"Pessoas com menos de 16 anos: {(pos * 100) / n:F1}%");

        }
    }
}
