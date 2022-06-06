using System;

class Program
{
    static void Main(string[] args)
    {

        double x, y, z;
        x = 3.0;
        y = 4.0;
        z = -5.0;

        double A, B, C;
        
        A = Math.Sqrt(x);
        B = Math.Sqrt(y);
        C = Math.Sqrt(25.0);

        Console.WriteLine("Raiz quadrada de x = " + A.ToString("F2"));
        Console.WriteLine("Raiz quadrada de y = " + B);
        Console.WriteLine("Raiz quadrada de 25 = " + C);

        A = Math.Pow(x, y);
        B = Math.Pow(x,  2.0);
        C = Math.Pow(5.0, 2.0);

        Console.WriteLine("x elevado a y = " + A);
        Console.WriteLine("x elevado a 2 = " + B);
        Console.WriteLine("5 elevado a 2 = " + C);

        A = Math.Abs(y);
        B = Math.Abs(z);

        Console.WriteLine("Valor absoluto de y = " + A);
        Console.WriteLine("Valor absoluto de z = " + B);

        Console.ReadLine();

    }
}




