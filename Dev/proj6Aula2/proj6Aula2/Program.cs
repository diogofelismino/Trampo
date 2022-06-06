using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        double A, B, C, media;

        Console.Write("Entre com o valor da nota A: ");
        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Entre com o valor da nota B: ");
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Entre com o valor da nota C: ");
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        media = (A * 2 + B * 3 + C * 5) / 10;


        Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

        Console.ReadLine();


    }
}




