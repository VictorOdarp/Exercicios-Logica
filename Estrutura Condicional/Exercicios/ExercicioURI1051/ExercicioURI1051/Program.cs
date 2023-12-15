using System;
using System.Globalization;

namespace URI1051
{
    class Program
    {
        static void Main(string[] args)
        {

            double renda, imposto;

            renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (renda >= 0.00 && renda <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            if (renda >= 2000.1 && renda <= 3000.00)
            {
                imposto = (renda - 2000.0) * 0.8; 
                Console.WriteLine("R$ " +  imposto.ToString("F2"), CultureInfo.InvariantCulture);
            }
            if (renda >= 3000.01 && renda <= 4500.00)
            {
                imposto = (renda - 3000.0) * 0.18 + 1000 * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2"), CultureInfo.InvariantCulture);
            }
            if (renda > 4500.0)
            {
                imposto = (renda - 4500.0) * 0.28 + 1500 * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2"), CultureInfo.InvariantCulture);
            }









        }
    }



}