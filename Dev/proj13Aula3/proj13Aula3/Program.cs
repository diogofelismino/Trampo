using System;
using System.Globalization;

namespace proj13Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Entre com o valor da salário: ");
            double salario = double.Parse(Console.ReadLine());
            double reajuste;
            int porcento;

            if(salario >= 0 && salario <= 400.00)
            {
                reajuste = salario * 0.15;
                salario += (salario * 0.15);
                porcento = (int)(100 * 0.15);


                Console.WriteLine($"Novo salario: {salario:F2}\n Reajuste ganho: {reajuste:F2}\n" +
                    $"Em percentual: {porcento} %");
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                salario += (salario * 0.12);
                porcento = (int)(100 * 0.12);


                Console.WriteLine($"Novo salario: {salario:F2}\n Reajuste ganho: {reajuste:F2}\n" +
                    $"Em percentual: {porcento} %");
            }
            else if(salario >= 800.01 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                salario += (salario * 0.10);
                porcento = (int)(100 * 0.10);


                Console.WriteLine($"Novo salario: {salario:F2}\n Reajuste ganho: {reajuste:F2}\n" +
                    $"Em percentual: {porcento} %");
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                salario += (salario * 0.07);
                porcento = (int)(100 * 0.07);


                Console.WriteLine($"Novo salario: {salario:F2}\n Reajuste ganho: {reajuste:F2}\n" +
                    $"Em percentual: {porcento} %");
            }
            else if (salario > 2000.00)
            {
                reajuste = salario * 0.04;
                salario += (salario * 0.04);
                porcento = (int)(100 * 0.04);


                Console.WriteLine($"Novo salario: {salario:F2}\n Reajuste ganho: {reajuste:F2}\n" +
                    $"Em percentual: {porcento} %");
            }


        }
    }
}
