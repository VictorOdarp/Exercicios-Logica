using System;
using System.Globalization;



namespace Exercicio10Judge
{
    class Program
    {

        static void Main(string[] args)
        {
            int duração, horas, minutos, segundos;

            duração = int.Parse(Console.ReadLine());
            horas = duração / 3600;
            minutos = (duração % 3600) / 60;
            segundos = (duração % 3600) % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);





        }
    }
}
