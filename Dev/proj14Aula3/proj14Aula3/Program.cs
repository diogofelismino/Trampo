using System;

namespace proj14Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("O animal é vertebrado[V] ou invertebrado[I]: ");
            char primeiraEsc = char.Parse(Console.ReadLine().ToUpper());
            

            char segundaEsc = 'a';
            char terceiraEsc = 'a';


            if (primeiraEsc.Equals('V'))
            {
                Console.Write("O animal é uma ave[A] ou um mamifero[M]: ");
                 segundaEsc = char.Parse(Console.ReadLine().ToUpper());
                
                if(segundaEsc == 'A')
                {
                 Console.Write("Escolha se ele é carnívoro[C] ou onívoro[O]: ");
                   terceiraEsc = char.Parse(Console.ReadLine().ToUpper());
                }
                else if (segundaEsc == 'M')
                {
                    Console.Write("Escolha se ele é herbivoro[H] ou onívoro[O]: ");
                    terceiraEsc = char.Parse(Console.ReadLine().ToUpper());
                }

            }
            else if(primeiraEsc == 'I')
            {
                Console.Write("O animal é um inseto[I] ou um anelideo[A]: ");
                segundaEsc = char.Parse(Console.ReadLine().ToUpper());

                if (segundaEsc == 'I')
                {
                    Console.Write("Escolha se ele é hematofago[H] ou herbivoro[E]: ");
                    terceiraEsc = char.Parse(Console.ReadLine().ToUpper());
                }
                else if (segundaEsc == 'A')
                {
                    Console.Write("Escolha se ele é hematofago[H] ou onívoro[O]: ");
                    terceiraEsc = char.Parse(Console.ReadLine().ToUpper());
                }

            }



            if (primeiraEsc == 'V' && segundaEsc == 'A' && terceiraEsc == 'C')
            {
                Console.WriteLine("Animal escolhido: Aguia");
            }
            else if (primeiraEsc == 'V' && segundaEsc == 'A' && terceiraEsc == 'O')
            {
                Console.WriteLine("Animal escolhido: Pomba");
            }
            else if (primeiraEsc == 'V' && segundaEsc == 'M' && terceiraEsc == 'O')
            {
                Console.WriteLine("Animal escolhido: Homem");
            }
            else if (primeiraEsc == 'V' && segundaEsc == 'M' && terceiraEsc == 'H')
            {
                Console.WriteLine("Animal escolhido: Vaca");
            }
            else if (primeiraEsc == 'I' && segundaEsc == 'I' && terceiraEsc == 'H')
            {
                Console.WriteLine("Animal escolhido: Pulga");
            }
            else if (primeiraEsc == 'I' && segundaEsc == 'I' && terceiraEsc == 'E')
            {
                Console.WriteLine("Animal escolhido: Lagarta");
            }
            else if (primeiraEsc == 'I' && segundaEsc == 'A' && terceiraEsc == 'H')
            {
                Console.WriteLine("Animal escolhido: Sanguessuga");
            }
            else if (primeiraEsc == 'I' && segundaEsc == 'A' && terceiraEsc == 'O')
            {
                Console.WriteLine("Animal escolhido: Minhoca");
            }




        }
    }
}
