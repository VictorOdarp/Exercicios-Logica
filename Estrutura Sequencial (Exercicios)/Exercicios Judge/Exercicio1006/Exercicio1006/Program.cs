using System;
using System.Globalization;



namespace Exercicio6Judge
{
    class Program
    {

        static void Main(string[] args)
        {
            double A = 2;
            double B = 3;
            double C = 5;
            double NOTA1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double NOTA2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double NOTA3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double MediaFinal = ((NOTA1 * A) + (NOTA2 * B) + (NOTA3 * C)) / 10.0;

            Console.WriteLine("MEDIA = " + MediaFinal.ToString("F1"), CultureInfo.InvariantCulture);





        }

    }
}
