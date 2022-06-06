using System;

namespace proj12Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe a hora inicial do jogo: ");
            sbyte horaInicial = sbyte.Parse(Console.ReadLine());

            Console.Write("Informe a hora final do jogo: ");
            sbyte horaFinal = sbyte.Parse(Console.ReadLine());

            sbyte hora;

            if(horaInicial == 0 && horaFinal == 0)
            {
                Console.WriteLine("O JOGO DUROU 24 HORAS (S)");
            }
            else if (horaFinal < horaInicial)
            {
                Console.WriteLine($"O JOGO DUROU {(horaFinal + 24) - horaInicial} HORAS (S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {horaFinal - horaInicial} HORAS (S)");
            }



        }
    }
}
