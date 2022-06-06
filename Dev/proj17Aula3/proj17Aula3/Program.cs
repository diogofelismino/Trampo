using System;

namespace proj17Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o codigo do empregado: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Informe o ano de seu nascimento: ");
            int anoNasc = int.Parse(Console.ReadLine());

            Console.Write("Informe o ano de ingrsso na empresa: ");
            int anoIngres = int.Parse(Console.ReadLine());


            int idade, tempoServiço;

            idade = 2022 - anoNasc;
            tempoServiço = 2022 - anoIngres;

            bool aposenta = (idade >= 65 || tempoServiço >= 30) || (idade >= 60 && tempoServiço >=25);

            Console.WriteLine($"Idade: {idade}, Tempo de Trabalho: {tempoServiço}");

            if (aposenta)
            {
                Console.WriteLine("Requer aposentadoria");
            }
            else
            {
                Console.WriteLine("Não requer");
            }


        }
    }
}
