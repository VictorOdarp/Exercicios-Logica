using System;
using System.Globalization;



namespace Exercicio10Judge
{
    class Program
    {

        static void Main(string[] args)
        {

            int Raio = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Pi = 3.14159;
            double Formula = (4.0 / 3) * Pi * Math.Pow(Raio, 3);

            Console.WriteLine("VOLUME = " + Formula.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
