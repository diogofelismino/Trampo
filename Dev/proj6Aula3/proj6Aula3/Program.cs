using System;

namespace proj6Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o código de usuário: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Informe a senha: ");
            int senha = int.Parse(Console.ReadLine());

            if(codigo != 1234)
            {
                Console.WriteLine("Usuário inválido!!!");
            }
            else if ( senha != 9999)
            {
                Console.WriteLine("Senha incorreta!!!");
            }
            else
            {
                Console.WriteLine("Acesso permitido!!!");
            }


        }
    }
}
