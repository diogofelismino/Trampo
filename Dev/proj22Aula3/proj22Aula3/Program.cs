using System;

namespace proj22Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o codigo do pedido: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade: ");
            int qtn = int.Parse(Console.ReadLine());

            double valorFinal = 0;

            switch (codigo)
            {
                case 100:
                    valorFinal = 1.70 * qtn;
                    break;

                case 101:
                    valorFinal = 2.30 * qtn;
                    break;

                case 102:
                    valorFinal = 2.60 * qtn;
                    break;

                case 103:
                    valorFinal = 2.40 * qtn;
                    break;

                case 104:
                    valorFinal = 2.50 * qtn;
                    break;

                case 105:
                    valorFinal = 1.00 * qtn;
                    break;

                case 000:
                    break;

                default:
                    Console.WriteLine("Codigo digitado invalido.");
                    break;

            }

            Console.WriteLine($"Valor total: {valorFinal}");

        }
    }
}
