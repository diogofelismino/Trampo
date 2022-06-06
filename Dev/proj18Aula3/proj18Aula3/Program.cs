using System;
using System.Globalization;

namespace proj18Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Informe a nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a nota: ");
            double n3 = double.Parse(Console.ReadLine());

            Console.Write("Informe a media de exercicio: ");
            double mediaEx = double.Parse(Console.ReadLine());

            double mediaAproveitamento = (n1 + (n2 * 2) + (n3 * 3) + mediaEx )/ 7;


            if(mediaAproveitamento >= 9.0)
            {
                Console.WriteLine("Conceito A");
            }
            else if (mediaAproveitamento < 9.0 && mediaAproveitamento >= 7.5)
            {
                Console.WriteLine("Conceito B");
            }
            else if (mediaAproveitamento < 7.5 && mediaAproveitamento >= 6.0)
            {
                Console.WriteLine("Conceito C");
            }
            else if (mediaAproveitamento < 6.0)
            {
                Console.WriteLine("Conceito D");
            }


        }
    }
}
