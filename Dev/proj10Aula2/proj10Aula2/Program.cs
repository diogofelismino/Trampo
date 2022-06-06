using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        /* CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

         int tempo, segundos, minutos, horas;

         Console.Write("Informe o tempo em segundos: ");
         tempo = int.Parse(Console.ReadLine());


         horas = tempo / 3600;
         segundos = tempo % 60;
         minutos = (tempo % 3600) / 60;

         // segundos = tempo % 60;
         // minutos = tempo / 60;
         // horas = minutos / 60 ;

         // if(minutos >= 60)
         //{
         //     minutos %= 60;
         //}


         Console.WriteLine($"{horas}:{minutos}:{segundos}");*/




        /*string s = Console.ReadLine();
        string[] vext = s.Split(" ");
        string p1 = vext[0];
        string p2 = vext[1];
        string p3 = vext[2];*/

        /*string[] vect = Console.ReadLine().Split(" ");

        string p1 = vect[0];
        string p2 = vect[1];
        string p3 = vect[2];
    
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);*/




        string[] vect = Console.ReadLine().Split(" ");
        string nome = vect[0];
        int idade = int.Parse(vect[1]);
        char sexo = char.Parse(vect[2]);
        double altura = double.Parse(vect[3]);


        Console.WriteLine(nome + " "+  idade+" "+  sexo +" " + altura);



    }
}




