using System;
using System.Globalization;

namespace proj8Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Quantos testes: ");
            int n = int.Parse(Console.ReadLine());

            int qtn =0;
            int total = 0;
            char esc = 'a';
            int sapo = 0;
            int rato = 0;
            int coelho = 0;
            

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().ToUpper().Split(" ");
                qtn = int.Parse(vect[0]);
                esc = char.Parse(vect[1]);

                total += qtn;
                switch (esc)
                {
                    case 'S':
                        sapo += qtn;
                        break;

                    case 'R':
                        rato += qtn;
                        break;


                    case 'C':
                        coelho += qtn;
                        break;

                    default:
                        total -= qtn;
                        break;

                }

                
            }

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelho}");
            Console.WriteLine($"Total de ratos: {rato} ");
            Console.WriteLine($"Total de sapos: {sapo} ");
            Console.WriteLine($"Porcentual de coelhos: {(double)((coelho * 100) / total):F2} ");
            Console.WriteLine($"Porcentual de ratos: {(double)((rato * 100) / total):F2} ");
            Console.WriteLine($"Porcentual de sapos: {(double)((sapo * 100) / total):F2} ");

            

        }
    }
}
