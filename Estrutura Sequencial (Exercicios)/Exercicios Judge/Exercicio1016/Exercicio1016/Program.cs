using System;
using System.Globalization;



namespace Exercicio16Judge
{
    class Program
    {

        static void Main(string[] args)
        {
            int QuilometrosDistancia = int.Parse(Console.ReadLine());
            int TempoDistancia = 2;
            int Tempo = QuilometrosDistancia * TempoDistancia;

            Console.WriteLine(Tempo + " minutos");


        }

    }
}