using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        double area, n, raio;
        n = 3.14159;

        Console.Write("Informe o valor do raio: ");
        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        area = n * Math.Pow(raio, 2);

        Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

        Console.ReadLine();

    }
}




