using System;
using System.Globalization;

namespace Exercicio10Judge
{
    class Program
    {

        static void Main(string[] args)
        {

            string Nome = Console.ReadLine(); 
            double SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double VendasEfetuadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Comissão = 0.15 * VendasEfetuadas;
            double TotalSalário = SalarioFixo + Comissão;

            Console.WriteLine("TOTAL = R$ " + TotalSalário.ToString("F2", CultureInfo.InvariantCulture));








        }
    }
}