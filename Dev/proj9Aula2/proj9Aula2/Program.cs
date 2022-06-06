using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        int horas, velocidadeMedia;
        double combustivel;

        Console.Write("Informe a quantidade de horas que foi percorido: ");

        horas = int.Parse(Console.ReadLine());


        Console.Write("Informe a velocidade media do veiculo: ");

        velocidadeMedia = int.Parse(Console.ReadLine());

        combustivel = (double)(horas * velocidadeMedia) / 12;

        Console.WriteLine("Combustivel gasto: " + combustivel.ToString("F3", CultureInfo.InvariantCulture));

        Console.ReadLine();



    }
}




