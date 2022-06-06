using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        double largura, comprimento, valorArea, areaTotal,  precoTotal;
        largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        valorArea = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        areaTotal = largura * comprimento;

        precoTotal = valorArea * areaTotal;

        Console.WriteLine("AREA = " + areaTotal.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("PRECO = " + precoTotal.ToString("F2", CultureInfo.InvariantCulture));
   
    }
}




