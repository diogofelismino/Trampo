using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        double nota1, nota2, media;

        Console.Write("Digite o valor da nota 1: ");
        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o valor da nota 2: ");
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = (nota1 * 3.5 + nota2 * 7.5) / 11;

        Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

        Console.ReadLine();

    }
}




