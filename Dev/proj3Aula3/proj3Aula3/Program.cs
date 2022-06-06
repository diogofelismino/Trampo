using System;

namespace proj3Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe sua idade: ");
            sbyte idade = sbyte.Parse(Console.ReadLine());

            Console.Write("É estudante ? [S/N] ");
            char estudante = char.Parse(Console.ReadLine().ToUpper());

            if(idade > 65 || estudante == 'S')
            {
                Console.WriteLine("O valor  é R$15,00");
            }
            else
            {
                Console.WriteLine("O valor do ingrasso é R$30,00");
            }

        }
    }
}
