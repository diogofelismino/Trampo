using System;

namespace proj11Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira um valor: ");
            int valor = int.Parse(Console.ReadLine());
            int resto;

            Console.WriteLine($"{valor / 100} notas(s) de R$ 100,00");

            int nota50 = valor % 100;
            resto = nota50 % 50;
           
            Console.WriteLine($"{nota50 /= 50} notas(s) de R$ 50,00");

            int nota20 = resto;
            resto = nota20 % 20;
           
            Console.WriteLine($"{nota20 /= 20} notas(s) de R$ 20,00");

            int nota10 = resto;
            resto = nota10 % 10;      

            Console.WriteLine($"{nota10 /= 10} notas(s) de R$ 10,00");

            int nota5 = resto;
            resto = nota5 % 5;    

            Console.WriteLine($"{nota5 /= 5} notas(s) de R$ 5,00");

            int nota2 = resto;
            resto = nota2 % 2; 

            Console.WriteLine($"{nota2 /= 2} notas(s) de R$ 2,00");

            int nota1 = resto;
            resto = nota1 % 1;
            
            Console.WriteLine($"{nota1 /= 1} notas(s) de R$ 1,00");





        }
    }
}
