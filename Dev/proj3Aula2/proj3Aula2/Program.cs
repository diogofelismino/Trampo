using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        double ladoA, ladoB, area, perimetro, diagonal;

        Console.Write("Informe o valor do lado A do retângulo: ");
        ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Informe o valor do lado B do retângulo: ");
        ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        area = ladoA * ladoB;
        perimetro = (2 * ladoA) + (2 * ladoB);
        diagonal = Math.Sqrt( Math.Pow(ladoA, 2) + Math.Pow(ladoB, 2));


        Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));


    }
}




