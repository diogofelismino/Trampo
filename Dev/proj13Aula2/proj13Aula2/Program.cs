using System;
using System.Globalization;

namespace proj13Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.Write("Quanto quartos tem na sua casa ? ");
            int quarto = int.Parse(Console.ReadLine());

            Console.Write("Entr cm o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu nome, idade, altura (mesma linha):  ");

            string[] vect = Console.ReadLine().Split(" ");

            string nome = vect[0];
            int idade = int.Parse(vect[1]);
            double altura = double.Parse(vect[2]);

            Console.WriteLine($"{nomeCompleto}\n{quarto}\n{produto:F2}\n{nome}\n{idade}\n{altura:F2}");







        }
    }
}
