using System;

namespace proj2Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe a sua idade: ");
            sbyte idade = sbyte.Parse(Console.ReadLine());

            Console.Write("É associado ? [S/N]  ");
            char esc = char.Parse(Console.ReadLine().ToUpper());

            if(idade >= 65 || esc == 'S')
            {
                Console.WriteLine("A pesso possui desconto: True");
            }
            else
            {
                Console.WriteLine("A pessoa possui desconto: False");
            }

        }
    }
}
