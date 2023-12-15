using System;
using System.Globalization;



namespace Exercicio14Judge
{
    class Program
    {

        static void Main(string[] args)
        {
            int DistanciaTotal = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double CombustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double ConsumoMedioAutomovel = DistanciaTotal / CombustivelGasto;

            Console.WriteLine(ConsumoMedioAutomovel.ToString("F3") + (" km/l"), CultureInfo.InvariantCulture);



          
        }

    }
}
