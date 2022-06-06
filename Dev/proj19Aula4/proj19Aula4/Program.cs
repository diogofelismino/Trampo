using System;
using System.Globalization;

namespace proj19Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            string[] vect;
            string nome;
            double nota1;
            double nota2;
            double media;

            string[] aprovado = new string[n];
            int j = 0;

            for(int i = 0; i < n; i++)
            {
                vect = Console.ReadLine().Split(" ");

                nome = vect[0];
                nota1 = double.Parse(vect[1]);
                nota2 = double.Parse(vect[2]);

                media = (double)((nota1 + nota2) / 2.0);

                if(media >= 6)
                {
                    aprovado[j] = vect[0]; 
                    j++;
                }
               

            }

            Console.WriteLine("Alunos aprovados: ");

            foreach(string s in aprovado)
            {
                Console.WriteLine(s);
            }


        }
    }
}
