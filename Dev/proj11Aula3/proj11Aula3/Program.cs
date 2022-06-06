using System;

namespace proj11Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            sbyte A = sbyte.Parse(Console.ReadLine());
            sbyte B = sbyte.Parse(Console.ReadLine());
            sbyte C = sbyte.Parse(Console.ReadLine());
            sbyte D = sbyte.Parse(Console.ReadLine());

            bool veMarior = B > C && D > A; // vai verifica se tanto b quanto d são os maiores e retonar true ou false
                                          
            bool  veSoma = (C + D) > (A + B); // vai ve se a soma de c e d é maior que a soma de a e b retornar true ou false

            bool positivo = C > 0 && D > 0; // ve se tanto C quanto D são positivos e retorna true ou false

            bool parA = A % 2 == 0; // verifica se o A é par ou não
                                    

            if(veMarior && veSoma && positivo && parA)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores não aceitos");
            }

        }
    }
}
