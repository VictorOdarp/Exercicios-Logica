using System;
using System.Globalization;

namespace URI1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, N4, N5, N6, Positivo, Média;
            Positivo = 0;
            Média = 0;

            N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (N1 > 0)
            {
                Positivo += 1;
                Média = Média + N1;
            }
            if (N2 > 0)
            {
                Positivo += 1;
                Média = Média + N2;
            }
            if (N3 > 0)
            {
                Positivo += 1;
                Média = Média + N3;
            }
            if (N4 > 0)
            {
                Positivo += 1;
                Média = Média + N4;
            }
            if (N5 > 0)
            {
                Positivo += 1;
                Média = Média + N5;
            }
            if (N6 > 0)
            {
                Positivo += 1;
                Média = Média + N6;
            }

            Média = Média / Positivo;
            Console.WriteLine(Positivo + " valores positivos");
            Console.WriteLine(Média.ToString("F1"));
        }
    }
}
