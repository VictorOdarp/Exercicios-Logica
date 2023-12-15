using System;
using System.Globalization;



namespace Exercicio10Judge
{
    class Program
    {

        static void Main(string[] args)
        {


            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota100 = (int) N / 100;
            double nota50 = (int) N % 100 / 50;
            double nota20 = (int) N % 100 % 50 / 20;
            double nota10 = (int) N % 100 % 50 % 20 / 10;
            double nota5 = (int) N % 100 % 50 % 20 % 10 / 5;
            double nota2 = (int) N % 100 % 50 % 20 % 10 % 5 / 2;
           
            double moeda1 = Math.Truncate(N % 100 % 50 % 20 % 10 % 5 % 2 / 1);
            double moeda50 = Math.Truncate(N % 100 % 50 % 20 % 10 % 5 % 2 % 1 / 0.50);
            double moeda25 = Math.Truncate(N % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.50 / 0.25);
            double moeda10 = Math.Truncate(N % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.50 % 0.25 / 0.10);
            double moeda5 = Math.Truncate(N % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.50 % 0.25 % 0.10 / 0.05);
            double moeda01 = Math.Truncate(N % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.50 % 0.25 % 0.10 % 0.05 / 0.01);

           



            Console.WriteLine("NOTAS:");
            Console.WriteLine(nota100 + " nota (s) de R$ 100.00");
            Console.WriteLine(nota50 + " nota (s) de R$ 50.00");
            Console.WriteLine(nota20 + " nota (s) de R$ 20.00");
            Console.WriteLine(nota10 + " nota (s) de R$ 10.00");
            Console.WriteLine(nota5 + " nota (s) de R$ 5.00");
            Console.WriteLine(nota2 + " nota (s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda1 + " moeda (s) de R$ 1.00");
            Console.WriteLine(moeda50 + " moeda (s) de R$ 0.50");
            Console.WriteLine(moeda25 + " moeda (s) de R$ 0.25");
            Console.WriteLine(moeda10 + " moeda (s) de R$ 0.10");
            Console.WriteLine(moeda5 + " moeda (s) de R$ 0.05");
            Console.WriteLine(moeda01+ " moeda (s) de R$ 0.01");





        }
    }
}