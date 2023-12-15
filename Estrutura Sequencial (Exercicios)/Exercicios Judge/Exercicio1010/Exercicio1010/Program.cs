using System;
using System.Globalization;



namespace Exercicio10Judge
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] PEÇA1 = Console.ReadLine().Split(' ');
            
            int CódigoPeça1 = int.Parse(PEÇA1[0], CultureInfo.InvariantCulture);
            double QuantidadePeça1 = double.Parse(PEÇA1[1], CultureInfo.InvariantCulture);
            double ValorPeça1 = double.Parse(PEÇA1[2], CultureInfo.InvariantCulture);

            string[] PEÇA2 = Console.ReadLine().Split(' ');

            int CódigoPeça2 = int.Parse(PEÇA2[0], CultureInfo.InvariantCulture);
            double QuantidadePeça2 = double.Parse(PEÇA2[1], CultureInfo.InvariantCulture);
            double ValorPeça2 = double.Parse(PEÇA2[2], CultureInfo.InvariantCulture);

            double TotalValorPeças1 = QuantidadePeça1 * ValorPeça1;
            double TotalValorPeças2 = QuantidadePeça2 * ValorPeça2;
            double TOTAL = TotalValorPeças1 + TotalValorPeças2;
            
            Console.WriteLine("VALOR A PAGAR: R$ " + TOTAL.ToString("F2"), CultureInfo.InvariantCulture);


            
        }
    }
}