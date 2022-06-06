using System;
using System.Globalization;

namespace proj18Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            
            int n = int.Parse(Console.ReadLine());

            string[] vect;
            double altura;
            char sexo;
            double menor = 10;
            double maior = 0;
            int homem= 0;
            int mue= 0;
            double total =0;
            double media;

            for(int i = 0; i < n; i++)
            {

                vect = Console.ReadLine().ToUpper().Split(" ");

                altura = double.Parse(vect[0]);
                sexo = char.Parse(vect[1]);

                if(menor> altura)
                {
                    menor = altura;
                }

                if(maior< altura)
                {
                    maior = altura;
                }

                if(sexo == 'F')
                {
                    total += altura;
                    mue++;
                }
                

                if(sexo == 'M')
                {
                    homem++;
                }



            }

            media = total / mue;

            Console.WriteLine($"Menor altura = {menor}");
            Console.WriteLine($"Maior altura = {maior}");
            Console.WriteLine($"Media das alturas das mulheres = {media}");
            Console.WriteLine($"Numero de homens = {homem}");

        }
    }
}
