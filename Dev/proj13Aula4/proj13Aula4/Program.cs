using System;
using System.Globalization;

namespace proj13Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            
            int T = int.Parse(Console.ReadLine());
            int PA = 100;
            int PB = 101;
            float G1;// Pa
            float G2;//Pb
            int cont = 0;
            

            int[] anos = new int[T];


            for(int i = 0; i < T; i++)
            {
                string[] vect = Console.ReadLine().Split(" ");
                PA = int.Parse(vect[0]);
                PB = int.Parse(vect[1]);
                G1 = float.Parse(vect[2]);
                G2 = float.Parse(vect[3]);

                G1 /= 100;
                G2 /= 100;

                while (PA < PB)
                {
                    PA += (int)(PA * G1);
                    PB += (int)(PB * G2);


                    cont++;

                }

                anos[i] = cont;
                cont = 0;


            }

            foreach (int a in anos)
            {

                if (a > 100)
                {
                    Console.WriteLine("Mais de um século");
                }
                else
                {
                    Console.WriteLine($"{a} anos");
                }

            }


        }
    }
}
