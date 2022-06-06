using System;

namespace proj15Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] vect = new int[5];

            int par =0;
            int impar=0;
            int pos=0;
            int neg=0;

            for(int i = 0; i < 5; i++)
            {

                Console.Write("Digite um numero: ");
                vect[i] = int.Parse(Console.ReadLine());

                if(vect[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }

                if (vect[i] > 0 && vect[i] != 0)
                {
                    pos++;
                }
                else if(vect[i] < 0 && vect[i] != 0)
                {
                    neg++;
                }
            }

            Console.WriteLine($"{par} valor(es) par(es)\n{impar} valor(es) impar(es)\n" +
                $"{pos} valor(es) positivo(es)\n" +
                $"{neg} valor(es) negativo(es)");

        }
    }
}
