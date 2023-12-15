using System;
using System.Globalization;



namespace Exercicio2Judge
{
    class Program
    {

        static void Main(string[] args)
        {
           double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           double N = 3.14159;
           double A = N * (raio * raio);

           Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));


         


        }

    }
}