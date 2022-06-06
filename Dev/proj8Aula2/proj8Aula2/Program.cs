using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        int numFucionario, horaTrabalhada;
        double valorPorHora, salario;

        Console.Write("Informe o número do funcionario: ");
        numFucionario = int.Parse(Console.ReadLine());

        Console.Write("Informe a caraga de horas trabalhada: ");
        horaTrabalhada = int.Parse(Console.ReadLine());

        Console.Write("Informe o valor por hora recebida: ");
        valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salario = horaTrabalhada * valorPorHora;

        Console.WriteLine("NUMBER = " + numFucionario);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        Console.ReadLine();

    }
}




