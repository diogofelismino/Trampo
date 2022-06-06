using System;
using System.Globalization;

namespace proj20Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Informe o codigo do produto: ");
            double codigo = double.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Alimentação não-perecível");
                    break;
                case  <= 4:
                    Console.WriteLine("Alimentação perecível");
                    break;

                case <=6:
                    Console.WriteLine("Vestuário");
                    break;
                case 7:
                    Console.WriteLine("Higiene Pessoal");
                    break;

                case <=15:
                    Console.WriteLine("Limpeza e Utensílios Domésticos");
                    break;

                default:
                    Console.WriteLine("Código inválido");
                    break;
            }



        }
        
        

        

        
    }
}
