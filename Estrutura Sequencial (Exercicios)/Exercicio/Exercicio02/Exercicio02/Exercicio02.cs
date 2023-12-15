using System;
using System.Globalization;



namespace Exercicio2
{
    class Program
    {

        static void Main(string[] args)
        {
           
            double Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Área = Base * Altura;
            double Perimetro = ( 2 * Base ) + ( 2 * Altura );
            double Diagonal = Math.Sqrt(Base * Base + Altura * Altura);


            Console.WriteLine("Área = " + Área.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Perimentro = " +  Perimetro.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Diagonal = " +  Diagonal.ToString("F4"), CultureInfo.InvariantCulture);

        }

    }
}
