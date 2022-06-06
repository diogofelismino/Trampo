using System;

class Program
{
    static void Main(string[] args)
    {

        int A, B, C, D, diferenca;

        Console.Write("Entre com o valor de A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Entre com o valor de B: ");
        B = int.Parse(Console.ReadLine());

        Console.Write("Entre com o valor de C: ");
        C = int.Parse(Console.ReadLine());

        Console.Write("Entre com o valor de D: ");
        D = int.Parse(Console.ReadLine());


        diferenca = (A * B - C * D);

        Console.WriteLine("DIFERENCA = " + diferenca);

        Console.ReadLine();

    }
}




