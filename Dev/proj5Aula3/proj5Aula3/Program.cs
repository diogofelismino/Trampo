using System;
using System.Globalization;

namespace proj5Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Quantos Kg de maça ira comprar: ");
            double maca = double.Parse(Console.ReadLine());

            Console.Write("Quantos Kg de morango ira comprar: ");
            double morango = double.Parse(Console.ReadLine());

            double valor;

            if(maca <= 5.0)
            {
                valor = maca * 1.80;
            }        
            else
            {
                valor = maca * 1.50;
            }


            if(morango <= 5.0)
            {
                valor += morango * 2.50;
            }
            else
            {
                valor += morango * 1.50;
            }


            if(valor > 25.00 || (maca + morango) > 8.0)
            {
                valor -= (valor * 0.1);
            }

            Console.WriteLine($"O valor total a se pago é: {valor:F2}");

            

        }
    }
}
