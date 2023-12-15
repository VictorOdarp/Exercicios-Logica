using System;
using System.Globalization;

namespace uri1005
{
    class Program
    {
        static void Main(string[] args) 
        {

            double PESO1 = 3.5;
            double PESO2 = 7.5;
            double NOTA1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double NOTA2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double MediaFinal = ((NOTA1 * PESO1) + (NOTA2 * PESO2)) / 11.0;

            Console.WriteLine("MEDIA = " + MediaFinal.ToString("F5"), CultureInfo.InvariantCulture);



            
        }
    }
}