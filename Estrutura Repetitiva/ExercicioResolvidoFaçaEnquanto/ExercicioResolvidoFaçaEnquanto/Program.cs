using System;
using System.Globalization;

namespace ExercicioResolvidoFaçaEnquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celcius, Fahrenheit;
            string repetir;

            do
            {
                Console.Write("Digite a temperatura em Celcius: ");
                Celcius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Fahrenheit = (9.0 * Celcius) / 5 + 32;
                Console.WriteLine("Equivalente em Fahrenheit: " + Fahrenheit.ToString("F1"), CultureInfo.InvariantCulture);
                Console.Write("Deseja repetir (s/n) ? ");
                repetir = Console.ReadLine();



            } while (repetir == "s");
    } }
}