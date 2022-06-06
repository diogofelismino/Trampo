using System;
using System.Globalization;

namespace proj4Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Informe que tipo de combustível deseja: [G(Gasolina)/ A(Álcool)] ");
            char escolha = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Informe a quantidade de combustível a ser abastecido em litros: ");
            int litros = int.Parse(Console.ReadLine());

            double valor;


            if(escolha == 'A' && litros <= 20)
            {
                valor = litros * 4.90;
                valor -= ( valor * 0.03);

                Console.WriteLine($"O combustivel escolhido foi Álcool e o valor a se pago é: {valor}");
            }
            else if(escolha == 'A' && litros > 20)
            {
                valor = litros * 4.90;
                valor -= (valor * 0.05);

                Console.WriteLine($"O combustivel escolhido foi Álcool e o valor a se pago é: {valor}");
            }
            else if (escolha == 'G' && litros <= 20)
            {
                valor = litros * 7.30;
                valor -= (valor * 0.04);

                Console.WriteLine($"O combustivel escolhido foi Gasolina e o valor a se pago é: {valor}");
            }
            else if(escolha == 'G' && litros > 20)
            {
                valor = litros * 7.30;
                valor -= (valor * 0.06);

                Console.WriteLine($"O combustivel escolhido foi Gasolina e o valor a se pago é: {valor}");
            }

        }
    }
}
