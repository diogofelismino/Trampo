using System;
using System.Globalization;

namespace proj6Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;   

            Console.Write("Quantas medias serão calculadas: ");
            int n = int.Parse(Console.ReadLine());
            
            double nota1;
            double nota2;
            double nota3;
            double[] meida = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(" ");
                nota1 = double.Parse(vect[0]);
                nota2 = double.Parse(vect[1]);
                nota3 = double.Parse(vect[2]);
               
                meida[i] = (nota1*2 + nota2*3 + nota3*5) / 10;   


            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"media: {meida[i]:F1}");
            }

        }
    }
}
