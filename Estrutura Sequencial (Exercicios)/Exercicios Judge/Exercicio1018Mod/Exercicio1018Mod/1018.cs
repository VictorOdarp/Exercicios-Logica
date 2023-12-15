using System;



namespace Exercicio10Judge
{
    class Program
    {

        static void Main(string[] args)
        {


            int N = int.Parse(Console.ReadLine());
            int nota100 = N / 100;
            int nota50 = N % 100 / 50;
            int nota20 = N % 100 % 50 / 20;
            int nota10 = N % 100 % 50 % 20 / 10;
            int nota5 = N % 100 % 50 % 20 % 10 / 5;
            int nota2 = N % 100 % 50 % 20 % 10 % 5 / 2;
            int nota1 = N % 100 % 50 % 20 % 10 % 5 % 2 / 1;

            Console.WriteLine(nota100 + " nota (s) de R$ 100,00");
            Console.WriteLine(nota50 + " nota (s) de R$ 50,00");
            Console.WriteLine(nota20 + " nota (s) de R$ 20,00");
            Console.WriteLine(nota10 + " nota (s) de R$ 10,00");
            Console.WriteLine(nota5 + " nota (s) de R$ 5,00");
            Console.WriteLine(nota2 + " nota (s) de R$ 2,00");
            Console.WriteLine(nota1 + " nota (s) de R$ 1,00");





        }
    }
}
