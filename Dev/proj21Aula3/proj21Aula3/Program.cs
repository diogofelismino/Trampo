using System;
using System.Globalization;

namespace proj21Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo.DefaultThreadCurrentCulture = 
                CultureInfo.InvariantCulture;

            Console.Write("Informe uma nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Informe uma nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write(@"Escolha uma opção: 
1 - Média
2 - Diferença
3 - Produto
4 - Divisão

Escolha:  ");

            sbyte esc = sbyte.Parse(Console.ReadLine());


            switch (esc)
            {
                case 1:
                    Console.WriteLine($"Media: {(n1 + n2)/ 2}");
                    break;

                case 2:
                    Console.WriteLine($"Diferença: {(n1 - n2)}");
                    break;

                case 3:
                    Console.WriteLine($"Produto: {(n1 * n2)}");
                    break;

                case 4:
                    Console.WriteLine($"Media: {(n1 / n2)}");
                    break;

                default:
                    Console.WriteLine("Opção invalida");
                    break;





            }




        }
    }
}
