using System;

namespace proj10Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe um numero de 1 a 7 para ver o dia da semana: ");
            sbyte dia = sbyte.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Dia da semana: Domingo");
                    break;
                case 2:
                    Console.WriteLine("Dia da semana: Segunda");
                    break;
                case 3:
                    Console.WriteLine("Dia da semana: Terça");
                    break;
                case 4:
                    Console.WriteLine("Dia da semana: Quarta");
                    break ;
                case 5:
                    Console.WriteLine("Dia da semana: Quinta");
                    break;
                case 6:
                    Console.WriteLine("Dia da semana: Sexta");
                    break;
                case 7:
                    Console.WriteLine("Dia da semana: Sabado");
                    break;
                default:
                    Console.WriteLine("Dia da semana: Valor inválido");
                    break;

            }

        }
    }
}
