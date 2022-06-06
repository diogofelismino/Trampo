using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

       // double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double a = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        sbyte s = sbyte.Parse(Console.ReadLine());
        int qtd = int.Parse(Console.ReadLine());
        Console.WriteLine(a);
        Console.WriteLine(s);
        Console.WriteLine(qtd);

        a = Math.Ceiling(a);
        Console.WriteLine(a);
    }
}




