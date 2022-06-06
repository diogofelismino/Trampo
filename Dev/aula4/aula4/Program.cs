using System;

namespace aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           // string texto = Console.ReadLine().Substring(0, 1).ToUpper();
            //char letra = Convert.ToChar(texto.Substring(0,0));

           // Console.WriteLine(texto);
            // Console.WriteLine(letra);

            int fatorial = 1;

            for(int i = 1; i <=10; i++)
            {
                fatorial *= i;
                Console.WriteLine($"Fatoria de {i} = {fatorial}");
            }

            int num = int.Parse(Console.ReadLine());
            int fat =  1;

            for(int i = 1; i <= num; i++)
            {
                fat *= i;
            }
            Console.WriteLine($"fatorial de 5 = {fat}");

        }
    }
}
