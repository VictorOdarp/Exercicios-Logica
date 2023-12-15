using System;



namespace Exercicio10Judge
{
    class Program
    {

        static void Main(string[] args)
        {

            int IdadeEmDias = int.Parse(Console.ReadLine());
            int ano = IdadeEmDias / 365;
            int mes = IdadeEmDias % 365 / 30;
            int dias = IdadeEmDias % 365 % 30;

            Console.WriteLine(ano + " ano (s)");
            Console.WriteLine(mes + " mes (es)"); 
            Console.WriteLine(dias + " dia (s)");




        }
    }
}